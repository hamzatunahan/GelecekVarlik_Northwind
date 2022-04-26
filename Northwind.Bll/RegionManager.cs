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
    public class RegionManager<T, TDto> : GenericManager<Region, DtoRegion>, IRegionService
    {
        //IRegionRepository
        private readonly IRegionRepository regionRepository;

        public RegionManager(IServiceProvider service) : base(service)
        {
            regionRepository = service.GetService<IRegionRepository>();
        }

        public IResponse<IQueryable<DtoRegion>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
