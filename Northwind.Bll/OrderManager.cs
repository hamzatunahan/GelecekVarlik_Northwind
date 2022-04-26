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
    public class OrderManager<T, TDto> : GenericManager<Order, DtoOrder>, IOrderService
    {
        //IOrderRepository
        private readonly IOrderRepository orderRepository;
        public OrderManager(IServiceProvider service) : base(service)
        {
            orderRepository = service.GetService<IOrderRepository>();
        }
        public IResponse<IQueryable<DtoOrder>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}