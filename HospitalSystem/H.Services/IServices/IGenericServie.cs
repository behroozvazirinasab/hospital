using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.Services.IServices
{
    public interface IGenericServie<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        Task AddAsync(TEntity entity);



        void Remove(TEntity entity);
        void Remove(int id);

        void Update(TEntity entity);    


        TEntity FindById(int id);



        List<TEntity> GetAll();

        Task<List<TEntity>> GetAllAsync();


    }
}
