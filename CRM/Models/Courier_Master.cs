using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Courier_Master
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> phoneNumbers { get; set; }
        public List<string> Addresses { get; set; }
     
    }
}
