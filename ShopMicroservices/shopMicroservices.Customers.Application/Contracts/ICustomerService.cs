
using ShopMicroservices.Customers.Application.Base;
using ShopMicroservices.Customers.Application.DTO;

namespace ShopMicroservices.Customers.Application.Contracts
{
    public interface ICustomerService
    {
        ServiceResult GetCustomer();
        ServiceResult GetCustomerById (int id);
        ServiceResult UpdateCustomer(CustomerDtoUpdate customerDtoUpdate);
        ServiceResult RemoveCustomer(CustomerDtoRemove customerDtoRemove);
        ServiceResult SaveCustomer(CustomerDtoSave customerDtoSave);

    }
}
