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
    public class ProductsAboveAveragePriceManager<T, TDto> : GenericManager<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>, IProductsAboveAveragePriceService
    {
        // IProductsAboveAveragePriceRepository
        private readonly IProductsAboveAveragePriceRepository productsAboveAveragePriceRepository;
        public ProductsAboveAveragePriceManager(IServiceProvider service) : base(service)
        {
            productsAboveAveragePriceRepository = service.GetService<IProductsAboveAveragePriceRepository>();
        }
        public IResponse<IQueryable<DtoProductsAboveAveragePrice>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
