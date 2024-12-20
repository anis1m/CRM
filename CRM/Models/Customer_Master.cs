using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Customer_Master
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public Customer_Pricing Customer_Pricing { get; set; }


    }
}
