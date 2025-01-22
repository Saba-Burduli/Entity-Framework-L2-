using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework.models
{
    [Table("ProductCategorys")]
    public class ProductCategory
    {
        [Key]
        public int Product_Category_ID { get; set; }
        [Required]
        public string Category_Name { get; set; } = string.Empty;

        public virtual ICollection<Product>? Product { get; set; }


    }
}
