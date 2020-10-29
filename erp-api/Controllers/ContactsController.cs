using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : GenericController<Contact, ContactsRepository, string>
    {
        public ContactsController(ContactsRepository repository): base(repository)
        {   
        }
    }
}
