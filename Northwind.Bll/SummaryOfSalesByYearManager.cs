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
    public class SummaryOfSalesByYearManager<T, TDto> : GenericManager<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>, ISummaryOfSalesByYearService
    {
        //ISummaryOfSalesByYearRepository
        private readonly ISummaryOfSalesByYearRepository summaryOfSalesByYearRepository;

        public SummaryOfSalesByYearManager(IServiceProvider service) : base(service)
        {
            summaryOfSalesByYearRepository = service.GetService<ISummaryOfSalesByYearRepository>();
        }

        public IResponse<IQueryable<DtoSummaryOfSalesByYear>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
