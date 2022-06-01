using H.DataLayer.Context;
using H.DataMdel.AP;
using H.Services.IServices;
using H.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.IocConfig
{
    public static class AddCustomService
    {   
        public static void AddCustomsServices(this IServiceCollection services,string _connection)
        {

            services.AddScoped<BMDBContext>(dbc => new BMDBContext(_connection));
            services.AddDbContext<HDbContext>(options =>
                {
                    options.UseSqlServer(_connection);
                });

            services.AddScoped<IDaroService, DaroService>();
            
        }
    }
}
