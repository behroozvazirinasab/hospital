using H.DataMdel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataLayer.Context
{
    public class HDbContext : DbContext
    {
        public HDbContext(DbContextOptions options)
        : base(options)
        {

        }


        public DbSet<DaroModel> Daros { get; set; }

    }
}
