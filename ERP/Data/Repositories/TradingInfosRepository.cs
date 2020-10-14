using ERP.Models;
using ERP.Contexts;

namespace ERP.Data.Repositories
{
    public class TradingInfosRepository: GenericRepository<TradingInfo, ErpContext, string>
    {
        public TradingInfosRepository(ErpContext context): base(context)
        {

        }
    }
}