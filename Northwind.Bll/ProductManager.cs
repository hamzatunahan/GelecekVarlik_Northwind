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
    public class ProductManager<T, TDto> : GenericManager<Product, DtoProduct>, IProductService
    {
        //IProductRepository
        private readonly IProductRepository productRepository;
        public ProductManager(IServiceProvider service) : base(service)
        {
            productRepository = service.GetService<IProductRepository>();
        }
        public IResponse<IQueryable<DtoProduct>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
