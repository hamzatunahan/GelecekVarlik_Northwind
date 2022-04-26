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
    public class CustomerCustomerDemoManager<T, TDto> : GenericManager<CustomerCustomerDemo, DtoCustomerCustomerDemo>, ICustomerCustomerDemoService
    {
        //ICustomerCustomerDemoRepository
        private readonly ICustomerCustomerDemoRepository customerCustomerDemoRepository;

        public CustomerCustomerDemoManager(IServiceProvider service) : base(service)
        {
            customerCustomerDemoRepository = service.GetService<ICustomerCustomerDemoRepository>();
        }

        public IResponse<IQueryable<DtoCustomerCustomerDemo>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}