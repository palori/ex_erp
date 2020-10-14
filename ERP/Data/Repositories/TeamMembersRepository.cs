using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class TeamMembersRepository: GenericRepository<TeamMember, ErpContext, string>
    {
        public TeamMembersRepository(ErpContext context): base(context)
        {

        }
    }
}