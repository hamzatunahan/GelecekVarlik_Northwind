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
    public class QuarterlyOrderManager<T, TDto> : GenericManager<QuarterlyOrder, DtoQuarterlyOrder>, IQuarterlyOrderService
    {
        //IQuarterlyOrderRepository
        private readonly IQuarterlyOrderRepository quarterlyOrderRepository;

        public QuarterlyOrderManager(IServiceProvider service) : base(service)
        {
            quarterlyOrderRepository = service.GetService<IQuarterlyOrderRepository>();
        }
        public IResponse<IQueryable<DtoQuarterlyOrder>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
