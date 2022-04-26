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
    public class AlphabeticalListOfProductManager<T, TDto> : GenericManager<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>, IAlphabeticalListOfProductService
    {
        //IAlphabeticalListOfProductRepository
        public readonly IAlphabeticalListOfProductRepository alphabeticalListOfProductRepository;

        public AlphabeticalListOfProductManager(IServiceProvider service) : base(service)
        {
            alphabeticalListOfProductRepository = service.GetService<IAlphabeticalListOfProductRepository>();
        }

        public IResponse<IQueryable<DtoAlphabeticalListOfProduct>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}