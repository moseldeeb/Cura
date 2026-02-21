namespace Cura.Models
{
    public class Payment
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string Method { get; set; }
        public string AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

    }
}
