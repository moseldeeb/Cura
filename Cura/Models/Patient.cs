using System.Data.SqlTypes;

namespace Cura.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string GOV { get; set; }
        public string City { get; set; }
        public string street { get; set; }
        public string email { get; set; }
        public string Countrycode { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public BinaryData gender { get; set; }
    }
}
