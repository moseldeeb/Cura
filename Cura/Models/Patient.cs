using System.Data.SqlTypes;

namespace Cura.Models
{
    public class Patient
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Img { get; set; }
        public string GOV { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public BinaryData Gender { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
