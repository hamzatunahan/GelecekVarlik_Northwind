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
    public class ProductsByCategoryManager<T, TDto> : GenericManager<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        //IProductsByCategoryRepository
        private readonly IProductsByCategoryRepository productsByCategoryRepository;

        public ProductsByCategoryManager(IServiceProvider service) : base(service)
        {
            productsByCategoryRepository = service.GetService<IProductsByCategoryRepository>();
        }
        public IResponse<IQueryable<DtoProductsByCategory>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
