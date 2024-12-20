using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class HSN_Master
    {
        [Key]
        public int Id { get; set; }
        public string HasnCode { get; set; }
        public string Description { get; set; }
    }
}
