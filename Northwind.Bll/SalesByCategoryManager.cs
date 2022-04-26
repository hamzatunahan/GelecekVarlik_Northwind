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
    public class SalesByCategoryManager<T, TDto> : GenericManager<SalesByCategory, DtoSalesByCategory>, ISalesByCategoryService
    {
        //ISalesByCategoryRepository
        private readonly ISalesByCategoryRepository salesByCategoryRepository;

        public SalesByCategoryManager(IServiceProvider service) : base(service)
        {
            salesByCategoryRepository = service.GetService<ISalesByCategoryRepository>();
        }

        public IResponse<IQueryable<DtoSalesByCategory>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
