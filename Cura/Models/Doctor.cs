using System.Data.SqlTypes;

namespace Cura.Models
{
    public class Doctor
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public string Email { get; set; }
        public double Rating { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public SqlMoney Salary { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
