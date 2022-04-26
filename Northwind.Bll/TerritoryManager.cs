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
    public class TerritoryManager<T, TDto> : GenericManager<Territory, DtoTerritory>, ITerritoryService
    {
        //ITerritoryRepository
        private readonly ITerritoryRepository  territoryRepository;

        public TerritoryManager(IServiceProvider service) : base(service)
        {
            territoryRepository = service.GetService<ITerritoryRepository>();
        }

        public IResponse<IQueryable<DtoTerritory>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
