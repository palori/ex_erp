using erp_api.Models;
using erp_api.Contexts;

namespace erp_api.Repositories
{
    public class TradingInfosRepository: GenericRepository<TradingInfo, ErpContext, string>
    {
        public TradingInfosRepository(ErpContext context): base(context)
        {

        }
    }
}