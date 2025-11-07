namespace SmpPharmacyServer.Models
{
    public class Brigade
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Package> Packages { get; set; }
        public ICollection<Replenishment> Replenishments { get; set; }
    }
}
