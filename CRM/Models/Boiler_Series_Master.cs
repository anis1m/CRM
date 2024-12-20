using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Boiler_Series_Master
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Head { get; set; }
        public string Series_Code { get; set; }
        public string Description { get; set; }
    }
}
