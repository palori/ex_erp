using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;

namespace erp_api.Services
{
    public class SupplierContactService: IService
    {
        private readonly SuppliersRepository suppliers;
        private readonly ContactsRepository contacts;
        public SupplierContactService(){}
        public SupplierContactService(SuppliersRepository suppliers, ContactsRepository contacts)
        {
            this.suppliers = suppliers;
            this.contacts = contacts;
        }

        public async Task<SupplierDto> Get(SupplierDto _supplier)
        {
            List<Supplier> suppliers = await this.suppliers.GetAll();
            List<Contact> contacts = await this.contacts.GetAll();

            Supplier selected_supplier = new Supplier();
            Contact selected_contact = new Contact();

            // find supplier in DB
            foreach (var supplier in suppliers)
            {
                if(supplier.Id == _supplier.Id)
                {
                    selected_supplier = supplier;
                    break;
                }
            }

            if (selected_supplier.Id != null)
            {
                // find supplier contact
                foreach (var contact in contacts)
                {
                    if(contact.Id == selected_supplier.ContactId)
                    {
                        selected_contact = contact;
                        break;
                    }
                }
            }

            return new SupplierDto(selected_contact, selected_supplier);
        }

        // GetAll() - Approach 1:
        public async Task<List<SupplierDto>> GetAll()
        {
            List<Supplier> suppliers = await this.suppliers.GetAll();
            List<Contact> contacts = await this.contacts.GetAll();
            List<SupplierDto> suppliersDto = new List<SupplierDto>();

            foreach (var supplier in suppliers)
            {
                // Find supplier contact
                Contact selected_contact = new Contact();
                foreach (var contact in contacts)
                {
                    if(contact.Id == supplier.ContactId)
                    {
                        selected_contact = contact;
                        break;
                    }
                }

                // create supplierDTO and append to the list
                suppliersDto.Add(new SupplierDto(selected_contact, supplier));
            }
            
            return suppliersDto;
        }

        public async Task<bool> Update(SupplierDto supplier0)
        {
            Supplier supplier = await this.suppliers.Get(supplier0.Id);
            supplier.Update<SupplierDto>(supplier0, null, null);

            // Find supplier contact
            Contact contact = await this.contacts.Get(supplier.ContactId);
            contact.Update<SupplierDto>(supplier0, null);

            // Update DB
            bool supplier_updated = false, contact_updated = false;

            supplier_updated = await this.suppliers.Update(supplier);
            if (supplier_updated)
            {
                contact_updated = await this.contacts.Update(contact);
            }
            
            return supplier_updated && contact_updated;
        }

        public async Task<SupplierDto> Add(SupplierDto supplier0)
        {
            // Some code to generate the Id's
            string cliId = "S3"; // generated somewhere
            //string addId = "A-"+cliId;
            string profId = cliId;
            string contId = cliId;
            supplier0.Id = cliId; // assign supplier Id, no matter what they send

            // Contact
            Contact contact = new Contact();
            contact.Update<SupplierDto>(supplier0, contId);
            Contact cont = await this.contacts.Add(contact);

            // Client
            Supplier supplier = new Supplier();
            supplier.Update<SupplierDto>(supplier0, contact, null);
            Supplier cli = await this.suppliers.Add(supplier);

            return new SupplierDto(cont, cli);
        }

        public async Task<SupplierDto> Delete(SupplierDto supplier0)
        {
            Supplier supplier = await this.suppliers.Get(supplier0.Id);
            Contact contact = await this.contacts.Get(supplier.ContactId);
            
            Supplier del_supplier = await this.suppliers.Delete(supplier);
            if (del_supplier != null)
            {
                Contact del_contact = await this.contacts.Delete(contact);
                // maybe check if contact has been deleted properly
            }

            // further considerations: compliance if some of them can be deleted bu not all...
            return new SupplierDto(contact, supplier);
        }

    }
}