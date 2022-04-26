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
    public class OrderSubtotalManager<T, TDto> : GenericManager<OrderSubtotal, DtoOrderSubtotal>, IOrderSubtotalService
    {
        //IOrderSubtotalRepository
       private readonly IOrderSubtotalRepository orderSubtotalRepository;
        public OrderSubtotalManager(IServiceProvider service) : base(service)
        {
            orderSubtotalRepository = service.GetService<IOrderSubtotalRepository>();
        }
        public IResponse<IQueryable<DtoOrderSubtotal>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}