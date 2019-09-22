using PhoneBook.Application.Interfaces;
using PhoneBook.Application.Services;
using PhoneBook.Domain.Interfaces;
using PhoneBook.Infra.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace PhoneBook.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IContactService, ContactService>();

            //Infra.Data Layer
            services.AddScoped<IContactRepository, ContactRepository>();
        }
    }
}
