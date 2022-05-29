using H.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.IocConfig
{
    public static class AddCustomService
    {   
        public static IServiceCollection AddCustomsServices(this IServiceCollection services)
        {
            services.AddDbContext<HDbContext>(options =>
                {
                    options.UseSqlServer();
                });
            return services;
        }
    }
}
