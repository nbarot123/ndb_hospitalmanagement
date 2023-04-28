using HospitalManagement.Core.Interfaces;
using HospitalManagement.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalManagement.Infrastructure.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HospitalDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HospitalDBConnection"));
            });
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductCategoryRepository,ProductCategoryRepository>();
            services.AddScoped<IDoctorCategoryRepository, DoctorCategoryRepository>();

            return services;

        }
    }
}
