using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Services
{
    public interface IServiceResponse<T, TIdType>
        where T : class, IEntity<TIdType>
    {
        DateTime Timestamp
        {
            get {return Timestamp;}
            set {Timestamp = DateTime.Now;}
        }
        bool Status {get; set;} // 0: success, 1: error
        string Message {get; set;}
        IEnumerable<T> Body {get; set;}
    }
}