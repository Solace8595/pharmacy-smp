namespace SmpPharmacyServer.Models
{
    public class Package
    {
        public int Id { get; set; }
        public int BrigadeId { get; set; }
        public Brigade Brigade { get; set; }

        public ICollection<PackageMedication> PackageMedications { get; set; }
    }
}
