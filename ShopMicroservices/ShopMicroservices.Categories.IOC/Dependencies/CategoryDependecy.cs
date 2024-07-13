using Microsoft.Extensions.DependencyInjection;
using ShopMicroservices.Categories.Application.Contracts;
using ShopMicroservices.Categories.Application.Services;
using ShopMicroservices.Categories.Domain.Entities;
using ShopMicroservices.Categories.Domain.Interfaces;
using ShopMicroservices.Categories.Persistance.Respositories;

namespace ShopMicroservices.Categories.IOC.Dependencies
{
    public static class CategoryDependency
    {
        public static void AddCategoryDependency(this IServiceCollection service)
        {
            #region "Repositorios"

            service.AddScoped<ICategoriesRepository, CategoryRepository>();
            
            #endregion

            #region Servicios

            service.AddTransient<ICategoryServices, CategoriesServices>();

            #endregion
        }
       

    }
}
