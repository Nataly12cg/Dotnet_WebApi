﻿using Microsoft.EntityFrameworkCore;
using MyVaccine.WebApi.Models;
using MyVaccine.WebApi.Literals;

namespace MyVaccine.WebApi.Configurations
{
    public static class DbConfigurations
    {
        public static IServiceCollection SetDatabaseConfiguration(this IServiceCollection services)
        {
            //var connectionString = Environment.GetEnvironmentVariable(MyVaccineLiterals.CONNECTION_STRING);
            var connectionString = "Server=localhost,14330;Database=MyVaccineAppDb;User Id=sa;Password=Abc.123456;TrustServerCertificate=True;";
            services.AddDbContext<MyVaccineAppDbContext>(options =>
                        options.UseSqlServer(
                                    connectionString
                                    )
                        );
            return services;
        }
    }
}
