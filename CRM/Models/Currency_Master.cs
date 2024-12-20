using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Currency_Master
    {
        [Key]
        public int Id { get; set; } 
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }    
        public int Rate { get; set; }
        public string Description { get; set; }
    }
}
