namespace SmpPharmacyServer.Models
{
    public class Replenishment
    {
        public int Id { get; set; }
        public int BrigadeId { get; set; }
        public Brigade Brigade { get; set; }

        public int MedicationId { get; set; }
        public Medication Medication { get; set; }

        public int Quantity { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
