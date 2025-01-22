using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homework.models
{
    [Table("Payments")]
    public class Payment
    {
        [Key]
        public int Payment_ID { get; set; }

        public  string Payment_Method { get; set; } = string.Empty;


        public string Bank_Name { get; set; } = string.Empty;

    }
}
