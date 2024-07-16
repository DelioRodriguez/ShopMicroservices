
using Microsoft.Extensions.DependencyInjection;
using ShopMicroservices.Customers.Application.Contracts;
using ShopMicroservices.Customers.Application.Services;
using ShopMicroservices.Customers.Domain.Interfaces;
using ShopMicroservices.Customers.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Customers.IOC.Dependencies
{
    public static class CustomerDependency
    {
        public static void AddCustomerDependency(this IServiceCollection  service)
        {
            #region "Repositorio"
            service.AddScoped<ICustomersRepository, CustomerRepository>();
            #endregion

            service.AddTransient<ICustomerService,CustomerService>();
        }
    }
}
