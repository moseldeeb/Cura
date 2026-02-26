namespace Cura.Models
{
    public class Clinic
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Phone { get; set; }
        public string ClinicNumber { get; set; }
        public string FloorNumber { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Appointment> Appointments { get; set; }
        
    }
}
