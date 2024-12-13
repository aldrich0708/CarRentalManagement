namespace CarRentalManagement.Domain
{
    public class Booking : BaseDomainModel
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Dateout { get; set; }
        public DateTime DateIn { get; set; }
    }
}
