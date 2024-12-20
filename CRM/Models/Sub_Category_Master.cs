using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Sub_Category_Master
    {
        [Key]
        public int Id { get; set; }
        public string SubCategory { get; set; }
        public string Description { get; set; } 
    }
}
