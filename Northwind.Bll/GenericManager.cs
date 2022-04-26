﻿using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace Northwind.Bll
{
    public class GenericManager<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {

        #region Variables
        private readonly IUnitofWork unitofWork;
        private readonly IServiceProvider service;
        private readonly IGenericRepository<T> repository;
        #endregion

        #region Constructor
        public GenericManager(IServiceProvider service)
        {
            this.service = service;
            unitofWork = service.GetService<IUnitofWork>();
            repository = unitofWork.GetRepository<T>();
        }
        #endregion

        #region Methods
        public IResponse<TDto> Add(TDto item, bool saveChanges = true)
        {
            try
            {
                var model = ObjectMapper.Mapper.Map<T>(item); //Dto tipi model(T) tipine donusturuluyor. Sebebi: Dal T ile calisir
                //var resolvesResult = String.Join(',',model.GetType().GetProperties().Select(x=>$" - {x.Name} : {x.GetValue(model) ?? ""} - "));
                var result = repository.Add(model);

                if (saveChanges)
                    Save(); //kaydetme islemi oldugundan  transactionı commitliyoruz

                return new Response<TDto>   //donus tipini ayarliyoruz
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T,TDto>(result)
                };
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "$Error",
                    Data = null
                };
            }
        }

        public async Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true)
        {
            try
            {
                var model = ObjectMapper.Mapper.Map<T>(item); //Dto tipi model(T) tipine donusturuluyor. Sebebi: Dal T ile calisir
                //var resolvesResult = String.Join(',',model.GetType().GetProperties().Select(x=>$" - {x.Name} : {x.GetValue(model) ?? ""} - "));
                var result = await repository.AddAsync(model);

                if (saveChanges)
                    Save(); //kaydetme islemi oldugundan  transactionı commitliyoruz

                return new Response<TDto>   //donus tipini ayarliyoruz
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(result)
                };
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "$Error",
                    Data = null
                };
            }
        }

        public IResponse<bool> DeleteById(int id, bool saveChanges = true)
        {
            try
            {
                repository.Delete(id);
                if (saveChanges)
                    Save();

                return new Response<bool>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data =true
                };
            }
            catch (Exception ex)
            {
                return new Response<bool>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = false
                };
            }
        }

        public IResponse<TDto> Find(int id)
        {
            try
            {
                var entity = ObjectMapper.Mapper.Map<T,TDto>( repository.Find(id));
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = entity
                };
            }
            catch (Exception ex)
            {
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll()
        {
            try
            {
                var list = repository.GetAll();

                var listDto = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();

                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            try
            {
                var list = repository.GetAll(expression);

                var listDto = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x)).ToList();

                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {
                return new Response<List<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public IResponse<IQueryable<TDto>> GetQueryable()
        {
            try
            {
                var list = repository.GetQueryable();
                var listDto = list.Select(x => ObjectMapper.Mapper.Map<TDto>(x));
                return new Response<IQueryable<TDto>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {
                return new Response<IQueryable<TDto>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public void Save()
        {
            unitofWork.Savechanges();
        }

        public IResponse<TDto> Update(TDto item, bool saveChanges = true)
        {
            try
            {
                //dto verisi model(T) tipine dönüştürülüyor.
                //sebebi:dal T ile çalışır.
                var model = ObjectMapper.Mapper.Map<T>(item);
                // var resolvesResult = String.Join(',', model.GetType().GetProperties().Select(x => $" - {x.Name} : {x.GetValue(model) ?? ""} - "));
                var result = repository.Update(model);

                if (saveChanges)
                {
                    Save(); //kaydetme işlemi olduğundan transaction'ı commit'liyoruz.
                }
                //dönüş tipini ayarlıyoruz
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Updated",
                    Data = ObjectMapper.Mapper.Map<T, TDto>(result)
                };
            }
            catch (Exception ex)
            {
                //hata olma durumunda dönecek veri seti
                return new Response<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }
        #endregion
    }
}