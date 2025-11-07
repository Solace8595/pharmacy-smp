namespace SmpPharmacyServer.Models
{
    public class PackageMedication
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }

        public int MedicationId { get; set; }
        public Medication Medication { get; set; }

        public int Quantity { get; set; }
    }
}
