using ClinicConnect.Application;
using ClinicConnect.Application.Mappings;
using ClinicConnect.Application.Services;
using ClinicConnect.Domain.Interfaces.Repository;
using ClinicConnect.Infra.Data;
using ClinicConnect.Infra.Data.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicConnect.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDoctorService, DoctorService>();

            services.AddAutoMapper(typeof(DtoMappingProfile));
            var myhandlers = AppDomain.CurrentDomain.Load("ClinicConnect.Application");
            services.AddMediatR(myhandlers);

            return services;
        }
    }
}