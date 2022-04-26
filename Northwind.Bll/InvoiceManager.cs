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
    public class InvoiceManager<T, TDto> : GenericManager<Invoice, DtoInvoice>, IInvoiceService
    {
        //IInvoiceRepository
        private readonly IInvoiceRepository ınvoiceRepository;

        public InvoiceManager(IServiceProvider service) : base(service)
        {
            ınvoiceRepository = service.GetService<IInvoiceRepository>();
        }

        public IResponse<IQueryable<DtoInvoice>> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}