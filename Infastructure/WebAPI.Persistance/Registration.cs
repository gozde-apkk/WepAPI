using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Persistance.Context;
using WebAPI.Persistance.Repositories;
using WepAPI.Application.Interfaces.Repositories;
using WepAPI.Application.Interfaces.UnitOfWorks;

namespace WebAPI.Persistance
{
    public static class Registration
    {
        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));


            services.AddScoped<IUnitOfWork ,  IUnitOfWork>();
        }

    }
}
