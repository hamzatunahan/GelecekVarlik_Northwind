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
    public class CurrentProductListManager<T, TDto> : GenericManager<CurrentProductList, DtoCurrentProductList>, ICurrentProductListService
    {
        //ICurrentProductListRepository
        public readonly ICurrentProductListRepository currentProductListRepository;

        public CurrentProductListManager(IServiceProvider service) : base(service)
        {
            currentProductListRepository = service.GetService<ICurrentProductListRepository>();
        }

        public IResponse<IQueryable<DtoCurrentProductList>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}