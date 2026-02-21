namespace Cura.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public string Duration { get; set; }
        public DateTime DateTime { get; set; }
    }
}
