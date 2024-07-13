using ShopMicroservices.Categories.Application.Base;
using ShopMicroservices.Categories.Application.DTO;

namespace ShopMicroservices.Categories.Application.Contracts;

public interface ICategoryServices
{
    ServiceResult GetCategories();
    ServiceResult GetCategoriesById(int id);
    ServiceResult UpdateCategories(CategoriesDtoUpdate categoryDtoUpdate);
    ServiceResult RemoveCategories(CategoriesDtoRemove categoryDtoRemove );
    ServiceResult SaveCategories(CategoriesDtoSave dtoSave);
}