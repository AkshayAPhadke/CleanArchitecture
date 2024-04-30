using CleanArchitectureDemo.Application.Context;
using CleanArchitectureDemo.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Infrastructure
{
    public static class RegisterService
    {
        public static void ConfigureInfraStructure(this IServiceCollection services,
  IConfiguration configuration)
        {
            services.AddDbContext<MyWorldDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyWorldDbConnection"));
            });

            services.AddScoped<IMyWorldDbContext>(option => {
                return option.GetService<MyWorldDbContext>();
            });

        }
    }
}
