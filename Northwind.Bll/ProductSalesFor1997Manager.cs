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
    public class ProductSalesFor1997Manager<T, TDto> : GenericManager<ProductSalesFor1997, DtoProductSalesFor1997>, IProductSalesFor1997Service
    {
        // IProductSalesFor1997Repository
        private readonly IProductSalesFor1997Repository productSalesFor1997Repository;

        public ProductSalesFor1997Manager(IServiceProvider service) : base(service)
        {
            productSalesFor1997Repository = service.GetService<IProductSalesFor1997Repository>();
        }
        public IResponse<IQueryable<DtoProductSalesFor1997>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
