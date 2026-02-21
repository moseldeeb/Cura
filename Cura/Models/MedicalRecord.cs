namespace Cura.Models
{
    public class MedicalRecord
    {
        public string Id { get; set; }
        public string Dignosis { get; set; }
        public string Note { get; set; }
        public DateTime  DateTime { get; set; }
        public string PatientId { get; set; } 
        public Patient Patient { get; set; }
        public string DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public List<Prescription> Prescriptions { get; set; }

    }
}
