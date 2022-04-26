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
    public class EmployeeTerritoryManager<T, TDto> : GenericManager<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService
    {
        //IEmployeeTerritoryRepository
        private readonly IEmployeeTerritoryRepository employeeTerritoryRepository;

        public EmployeeTerritoryManager(IServiceProvider service) : base(service)
        {
            employeeTerritoryRepository = service.GetService<IEmployeeTerritoryRepository>();
        }

        public IResponse<IQueryable<DtoEmployeeTerritory>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}