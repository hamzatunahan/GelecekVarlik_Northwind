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
    public class CustomerDemographicManager<T, TDto> : GenericManager<CustomerDemographic, DtoCustomerDemographic>, ICustomerDemographicService
    {
        //ICustomerDemographicRepository
        private readonly ICustomerDemographicRepository customerDemographicRepository;

        public CustomerDemographicManager(IServiceProvider service) : base(service)
        {
            customerDemographicRepository = service.GetService<ICustomerDemographicRepository>();
        }

        public IResponse<IQueryable<DtoCustomerDemographic>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}