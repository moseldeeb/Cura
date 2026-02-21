using System.Data.SqlTypes;

namespace Cura.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Receptionist { get; set; }
        public string Nurse { get; set; }
        public string Cleaner { get; set; }

        public string email { get; set; }
        public string Countrycode { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public SqlMoney Salary { get; set; }
    }
}
