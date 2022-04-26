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
    public class SummaryOfSalesByQuarterManager<T, TDto> : GenericManager<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>, ISummaryOfSalesByQuarterService
    {
        //ISummaryOfSalesByQuarterRepository
        private readonly ISummaryOfSalesByQuarterRepository summaryOfSalesByQuarterRepository;

        public SummaryOfSalesByQuarterManager(IServiceProvider service) : base(service)
        {
            summaryOfSalesByQuarterRepository = service.GetService<ISummaryOfSalesByQuarterRepository>();
        }

        public IResponse<IQueryable<DtoSummaryOfSalesByQuarter>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
