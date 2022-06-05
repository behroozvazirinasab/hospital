using H.DataLayer.Context;
using H.DataMdel.Models;
using H.DataMdel.ViewModel;
using H.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Services.Services
{
    public class DaroService : GenericServie<DaroModel> ,IDaroService
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<DaroModel> _daro;

        public DaroService(IUnitOfWork uow)
            : base(uow)
        {
            _uow = uow;
            _daro = uow.Set<DaroModel>();
        }





        //public void Add(DaroModel daroModel)
        //{
        //    _daro.Add(daroModel);
        //}

        //public List<DaroModel> GetAll()
        //    => _daro.ToList();
        
    }
}
