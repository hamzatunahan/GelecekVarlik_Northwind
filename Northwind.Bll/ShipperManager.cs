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
    public class ShipperManager<T, TDto> : GenericManager<Shipper, DtoShipper>, IShipperService
    {
        //IShipperRepository
        private readonly IShipperRepository  shipperRepository;

        public ShipperManager(IServiceProvider service) : base(service)
        {
            shipperRepository = service.GetService<IShipperRepository>();
        }

        public IResponse<IQueryable<DtoShipper>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
