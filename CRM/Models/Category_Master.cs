using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Category_Master
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

    }

    
}
