using ShopMicroservices.Categories.Application.Base;
using ShopMicroservices.Categories.Application.DTO;

namespace ShopMicroservices.Categories.Application.Extentions;
using ShopMicroservices.Categories.Application.DTO;

public  static class ValidCategory
{


        public static ServiceResult IsValidCategory(this CategoriesDtoSave categoryDtoSave)
        {
            ServiceResult result = new ServiceResult();

            if (categoryDtoSave is null)
            {
                result.Success = false;
                result.Message = $"El objeto {nameof(categoryDtoSave)} es requerido.";
                return result;
            }

            if (string.IsNullOrEmpty(categoryDtoSave.CategoryName))
            {
                result.Success = false;
                result.Message = $"El nombre de la categoría es requerido.";
                return result;
            }

            return result;
        }

        public static ServiceResult IsValidCategory(this CategoriesDtoUpdate categoryDtoUpdate)
        {
            ServiceResult result = new ServiceResult();

            if (categoryDtoUpdate is null)
            {
                result.Success = false;
                result.Message = $"El objeto {nameof(categoryDtoUpdate)} es requerido.";
                return result;
            }

            if (string.IsNullOrEmpty(categoryDtoUpdate.CategoryName))
            {
                result.Success = false;
                result.Message = $"El nombre de la categoría es requerido.";
                return result;
            }

           

            return result;
        }
    }
