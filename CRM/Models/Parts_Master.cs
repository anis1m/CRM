using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Parts_Master
    {
        [Key]
        public int Id { get; set; }
        public long PartNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnderGroup { get; set; }
        public int Units { get; set; }
        public int GST { get; set; }
        public string HSNDetails { get; set; }
        public TypesofSupply Supply { get; set; }  
        public int SellingPrice { get; set; }
        public int Weight { get; set; }
        public int dimensions { get; set; }
        public string packing { get; set; }
        public string MaterialOfConstruction { get; set; }
        public string Certification { get; set; }



        
    }

    public enum TypesofSupply
    {
        Goods,
        Service
    }
}
