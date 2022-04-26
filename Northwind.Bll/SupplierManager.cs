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
    public class SupplierManager<T, TDto> : GenericManager<Supplier, DtoSupplier>, ISupplierService
    {
        //ISupplierRepository
        private readonly ISupplierRepository supplierRepository;

        public SupplierManager(IServiceProvider service) : base(service)
        {
            supplierRepository = service.GetService<ISupplierRepository>();
        }

        public IResponse<IQueryable<DtoSupplier>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
