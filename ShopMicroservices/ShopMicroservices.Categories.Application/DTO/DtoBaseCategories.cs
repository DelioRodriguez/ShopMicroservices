namespace ShopMicroservices.Categories.Application.DTO;

public abstract class DtoBaseCategories : DtoBase
{
    public string? CategoryName { get; set; }
    public string? Description { get; set; }
    public int CategoryId { get; set; }
    
    
}