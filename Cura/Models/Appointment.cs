namespace Cura.Models
{
    public class Appointment
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string ClientId { get; set; }
        public Clinic Clinic { get; set; }
        public string StaffId { get; set; }
        public Staff Staff { get; set; }
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Payment Payment { get; set; }

    }
}
