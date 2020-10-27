using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class TeamMembersRepository: GenericRepository<TeamMember, ErpContext, string>
    {
        public TeamMembersRepository(ErpContext context): base(context)
        {

        }
    }
}