﻿using Northwind.Dal.Abstract;
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
    public class CustomerAndSuppliersByCityManager<T, TDto> : GenericManager<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        //ICustomerAndSuppliersByCityRepository
        public readonly ICustomerAndSuppliersByCityRepository customerAndSuppliersByCityRepository;

        public CustomerAndSuppliersByCityManager(IServiceProvider service) : base(service)
        {
            customerAndSuppliersByCityRepository = service.GetService<ICustomerAndSuppliersByCityRepository>();
        }

        public IResponse<IQueryable<DtoCustomerAndSuppliersByCity>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}