using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework.models
{

    [Table("Products")]
    public class Product
    {
        [Key]
        public int Products_ID { get; set; }
        [Required]
        public string Products_Name  { get; set; }  =string.Empty;

        [Required]
        public DateTime Realise_Date { get; set; }

        [Required]
        public short Product_Quantity { get; set; }

        [ForeignKey("Product_Categorys")]
        public int Product_Category_ID { get; set; }

        public string? Category_Name { get; set; }


        public virtual ICollection<ProductCategory> ProductCategory { get; set; }

    }
}
