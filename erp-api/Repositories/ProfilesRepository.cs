using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class ProfilesRepository: GenericRepository<Profile, ErpContext, string>
    {
        public ProfilesRepository(ErpContext context): base(context)
        {
        }
    }
}