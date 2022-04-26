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
    public class EmployeeManager<T, TDto> : GenericManager<Employee, DtoEmployee>, IEmployeeService
    {
        //IEmployeeRepository
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeManager(IServiceProvider service) : base(service)
        {
            employeeRepository = service.GetService<IEmployeeRepository>();
        }

        public IResponse<IQueryable<DtoEmployee>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}