using H.DataLayer.Context;
using H.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Services.Services
{
    public class GenericServie<TEntity> : IGenericServie<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _uow;
        private readonly DbSet<TEntity> _entity;

        public GenericServie(IUnitOfWork uow)
        {
            _uow = uow;
            _entity = uow.Set<TEntity>();
        }



        public void Add(TEntity entity)
            => _entity.Add(entity);


        public async Task AddAsync(TEntity entity)
            => await _entity.AddAsync(entity);



        public TEntity FindById(int id) 
            => _entity.Find(id);



        public List<TEntity> GetAll() 
            => _entity.ToList();


        public async Task<List<TEntity>> GetAllAsync()
            => await _entity.ToListAsync();



        public void Remove(TEntity entity)
            => _entity.Remove(entity);

        public void Remove(int id)
        {
            var p = _entity.Find(id);
            _entity.Remove(p);
        }

        public void Update(TEntity entity)
            => _entity.Update(entity);
    }
}
