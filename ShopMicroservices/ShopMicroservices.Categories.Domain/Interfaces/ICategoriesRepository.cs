using ShopMicroservices.Common.Data.Repository;

namespace ShopMicroservices.Categories.Domain.Interfaces
{
    public interface ICategoriesRepository : IRepositoryBase<ShopMicroservices.Categories.Domain.Entities.Categories,int>
    {
    
    }
}