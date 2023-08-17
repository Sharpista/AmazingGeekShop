using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AmazingGeekShop.API.APIModels;

public class ProductViewModel
{
    [Key]
    public Guid Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("price")]
    public decimal? Price { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("category")]
    public string? CategoryName { get; set; }
    
    [JsonPropertyName("imageURL")]
    public string? ImageURL { get; set; }
}