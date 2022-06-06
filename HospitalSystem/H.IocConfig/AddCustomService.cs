using H.DataLayer.Context;
using H.DataMdel.AP;
using H.DataMdel.idenModel;
using H.DataMdel.Models;
using H.Services.IServices;
using H.Services.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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

            services.AddScoped<IUnitOfWork, HDbContext>();
            services.AddScoped<IDaroService, DaroService>();


            services.AddIdentity<UserModel,Role>()
                .AddEntityFrameworkStores<HDbContext>()
                .AddDefaultTokenProviders();
            




        }
    }
}
