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
        public HDbContext(DbContextOptions<HDbContext> options)
        : base(options)
        {

        }






        public DbSet<DaroModel> Daros { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DaroModel>().HasData(
                new DaroModel { ID = 1, Title = "To Shiraz" },
                new DaroModel { ID = 2, Title = "To Esfahan" },
                new DaroModel { ID = 3, Title = "To Mashhad" }
            );
        }



        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
