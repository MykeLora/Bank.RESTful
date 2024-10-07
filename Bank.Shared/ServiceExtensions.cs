using AutoMapper;
using Bank.Aplication.Interfaces;
using Bank.Shared.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Shared
{
    public static class ServiceExtensions
    {
        public static void AddSharedInfraestructure(this IServiceCollection services )
        {
            services.AddTransient<IDateTimeService, DateTimeService>();
        }
    }
}
