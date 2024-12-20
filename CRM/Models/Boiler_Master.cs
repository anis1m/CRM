using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Boiler_Master
    {
        [Key]
        public int Id { get; set; }
        public string Head { get; set; }
        public string Description { get; set; }
    }
}
