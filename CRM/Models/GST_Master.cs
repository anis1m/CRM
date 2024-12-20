using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class GST_Master
    {
        [Key]
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }
    }
}
