using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Entity.IBase;

namespace Northwind.Bll
{
    public class OrdersQryManager<T, TDto> : GenericManager<OrdersQry, DtoOrdersQry>, IOrdersQryService
    {
        //IOrdersQryRepository
        private readonly IOrdersQryRepository ordersQryRepository;

        public OrdersQryManager(IServiceProvider service) : base(service)
        {
            ordersQryRepository = service.GetService<IOrdersQryRepository>();
        }
        public IResponse<IQueryable<DtoOrdersQry>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}