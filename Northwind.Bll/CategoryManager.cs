﻿using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.IBase;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class CategoryManager<T, TDto> : GenericManager<Category, DtoCategory>, ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;

        public CategoryManager(IServiceProvider service) : base(service)
        {
            categoryRepository = service.GetService<ICategoryRepository>();
        }

        public IResponse<IQueryable<DtoCategory>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}