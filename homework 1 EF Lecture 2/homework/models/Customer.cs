using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework.models
{


    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }

        
        public string Customer_Name { get; set; } = string.Empty;

        public string Customer_Addres { get; set; } = string.Empty;


        public virtual ICollection<Order>? Orders { get; set; }
    }
}
