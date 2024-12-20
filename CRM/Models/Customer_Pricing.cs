using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Customer_Pricing
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int Percentage { get; set; }
        public string Description { get; set; }
    }
}
