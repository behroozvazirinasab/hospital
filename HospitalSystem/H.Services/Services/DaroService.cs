using H.DataLayer.Context;
using H.DataMdel.Models;
using H.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Services.Services
{
    public class DaroService : IDaroService
    {
        private readonly HDbContext _dbContext;
        private readonly DbSet<DaroModel> _daro;

        public DaroService(HDbContext dbContext)
        {
            _dbContext = dbContext;
            _daro = dbContext.Set<DaroModel>();
        }





        public void Add(DaroModel daroModel) 
            => _daro.Add(daroModel);


        public List<DaroModel> GetAll()
            => _daro.ToList();
        
    }
}
