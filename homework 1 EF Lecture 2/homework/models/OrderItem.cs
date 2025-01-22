using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework.models
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        public int OrderItem_ID { get; set; }

        [MaxLength(30 , ErrorMessage = "U have to enter less than 20 characters")] ,
        [MaxLength(2 , ErrorMessage = "U have to enter more than 2")]

        [Required]
        public string OrderItem_Name { get; set; } = string.Empty;
        

        [ForeignKey("Payment")]
        public int  Payment_ID { get; set; }

        [Required]
        public string Payment_Method { get; set; } = string.Empty;

        [Required]
        public string Bank_Name { get; set; } = string.Empty;




    }
}
