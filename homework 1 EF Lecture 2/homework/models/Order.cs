using System.ComponentModel.DataAnnotations.Schema;

namespace homework.models
{

    [Table("Orders")]
    public class Order
    {
        public int Order_ID { get; set; }

        public string Order_Name { get; set; } = string.Empty;

        public string Order_Description { get; set; } = string.Empty;


        [ForeignKey("Customers")]
        public int Customer_ID { get; set;}

        public string Customer_Name { get; set; } = string.Empty;


        public string Customer_Addres { get; set; } = string.Empty;


        [ForeignKey("OrderItems")]
        public int OrderItem_ID { get; set; } 

        public string OrderItem_Name { get;set; } = string.Empty;

        public string Payment_Method { get; set; } = string.Empty; 

        public string Bank_Name { get; set; } =string.Empty;


        public virtual Customer? Customer { get; set; }
    }
}
