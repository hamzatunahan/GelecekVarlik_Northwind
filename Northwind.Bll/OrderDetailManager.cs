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
    public class OrderDetailManager<T, TDto> : GenericManager<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        //IOrderDetailRepository
        private readonly IOrderDetailRepository orderDetailRepository;
        public OrderDetailManager(IServiceProvider service) : base(service)
        {
            orderDetailRepository = service.GetService<IOrderDetailRepository>();
        }
        public IResponse<IQueryable<DtoOrderDetail>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}