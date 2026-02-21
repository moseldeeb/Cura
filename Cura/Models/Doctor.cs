using System.Data.SqlTypes;

namespace Cura.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Title { get; set; }
        
        public string email { get; set; }
        public string Countrycode { get; set; }
        public string Phone { get; set; }
        public DateTime HireDate { get; set; }
        public SqlMoney Salary { get; set; }

    }
}
