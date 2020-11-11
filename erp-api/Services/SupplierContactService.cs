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

    }
}