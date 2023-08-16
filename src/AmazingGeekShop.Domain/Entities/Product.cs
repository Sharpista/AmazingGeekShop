
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AmazingGeekShop.Domain.Base;

namespace AmazingGeekShop.Domain.Entities
{

    [Table("product")]
    public class Product : EntityBase
    {
        [Column("product_name")]
        [Required]
        [StringLength(150)]
        public string? Name { get; set; }
        
        [Column("product_price")]
        [Required]
        public decimal? Price { get; set; }
        
        [Column("product_description")]
        public string? Description { get; set; }
        
        [Column("product_category_name")]
        [StringLength(50)]
        public  string? CategoryName { get; set; }
        
        [Column("product_image_url")] 
        public string? ImageURL { get; set; }
        
    }
}