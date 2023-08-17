namespace AmazingGeekShop.Application.Products.Command;
using MediatR;
public class ProductCommand
{
    public string? Name { get; set; }
    
    public decimal? Price { get; set; }
    
    public string? Description { get; set; }
    
    public string? CategoryName { get; set; }
    
    public string? ImageURL { get; set; }
}