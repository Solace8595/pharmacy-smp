namespace SmpPharmacyServer.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QrCode { get; set; }
        public int TotalQuantity { get; set; }
        public DateTime ExpiryDate { get; set; }

        public ICollection<PackageMedication> PackageMedications { get; set; }
        public ICollection<Replenishment> Replenishments { get; set; }
    }
}
