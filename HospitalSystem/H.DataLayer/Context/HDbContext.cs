using H.DataMdel.idenModel;
using H.DataMdel.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataLayer.Context
{
    public class HDbContext : IdentityDbContext<UserModel ,Role ,int ,UserClaim ,UserRole ,UserLogin ,RoleClaim ,UserToken> 
        , IUnitOfWork
    {
        public HDbContext(DbContextOptions options)
        : base(options)
        {

        }






        public DbSet<DaroModel> Daros { get; set; }






        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
