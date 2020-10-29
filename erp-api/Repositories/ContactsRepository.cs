using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ContactsRepository: GenericRepository<Contact, ErpContext, string>
    {
        public ContactsRepository(ErpContext context): base(context)
        {

        }
    }
}