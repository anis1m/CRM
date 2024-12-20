using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Unit_Master
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
