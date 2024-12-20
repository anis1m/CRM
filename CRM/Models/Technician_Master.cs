using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Technician_Master
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public long phoneNumber { get; set; }
        public short age { get; set; }
        public string qualification { get; set; }
        public short experience { get; set; }
        public short NumberOfYearsWithRoss { get; set; }
        public int CTC {  get; set; }
        public string Posting_Location { get; set; }
        public long Aadhar {  get; set; }
        public string PAN { get; set; }
        public string Residential_Address { get; set; }
        public long PhoneNumber { get; set; }
    }
}
