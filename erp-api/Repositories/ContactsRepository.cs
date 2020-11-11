using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Contexts;
using erp_api.Data.DTO;

namespace erp_api.Repositories
{
    public class ContactsRepository: GenericRepository<Contact, ErpContext, string>
    {
        public ContactsRepository(ErpContext context): base(context)
        {

        }

        public async Task<Contact> GetAuthenticate(AuthenticateRequest model)
        {
            var contacts = await GetAll();
            return contacts.Find(x => x.Email == model.Username && x.Password == model.Password);
        }

        public async Task<bool> IsEmail(string email) // useful for registration
        {
            var contacts = await GetAll();
            var contact = contacts.Find(x => x.Email == email);
            return (contact == null)? false : true;
        }
    }
}