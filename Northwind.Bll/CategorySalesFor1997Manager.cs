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
    public class CategorySalesFor1997Manager<T, TDto> : GenericManager<CategorySalesFor1997, DtoCategorySalesFor1997>, ICategorySalesFor1997Service
    {
        //ICategorySalesFor1997Repository
        public readonly ICategorySalesFor1997Repository categorysalesby1997Repository;

        public CategorySalesFor1997Manager(IServiceProvider service) : base(service)
        {
            categorysalesby1997Repository = service.GetService<ICategorySalesFor1997Repository>();
        }

        public IResponse<IQueryable<DtoCategorySalesFor1997>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}