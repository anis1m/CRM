using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Boiler_Series_Parts_Mapping
    {
        [Key]
        public int Id { get; set; }
        public string Head { get; set; }
        public string Series { get; set; }
        public string Description { get; set; }
        public List<Parts_Master> DisplayAllParts { get; set; }
    }
}
