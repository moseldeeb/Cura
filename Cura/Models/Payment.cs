namespace Cura.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string Method { get; set; }

    }
}
