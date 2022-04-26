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
    public class OrderDetailsExtendedManager<T, TDto> : GenericManager<OrderDetailsExtended, DtoOrderDetailsExtended>, IOrderDetailsExtendedService
    {
        //IOrderDetailsExtendedRepository
        private readonly IOrderDetailsExtendedRepository orderDetailsExtendedRepository;

        public OrderDetailsExtendedManager(IServiceProvider service) : base(service)
        {
            orderDetailsExtendedRepository = service.GetService<IOrderDetailsExtendedRepository>();
        }
        public IResponse<IQueryable<DtoOrderDetailsExtended>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}