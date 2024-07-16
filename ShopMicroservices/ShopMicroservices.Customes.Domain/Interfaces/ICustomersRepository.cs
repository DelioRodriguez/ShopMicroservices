using ShopMicroservices.Common.Data.Repository;


namespace ShopMicroservices.Customers.Domain.Interfaces
{
    public interface ICustomersRepository : IRepositoryBase<ShopMicroservices.Customers.Domain.Entities.Customers,int>
    {

    }
    
}
