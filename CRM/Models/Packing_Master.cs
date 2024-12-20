using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Packing_Master
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
