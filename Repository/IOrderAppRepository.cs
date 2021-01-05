using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore3._1_Store.Data;

namespace Asp.netCore3._1_Store.Repository
{
    interface IOrderAppRepository:IBaseRepository<OrderApp>
    {
        public ICollection<OrderApp> GetOrderAppByCustomer(string CustomerName);
    }
}
