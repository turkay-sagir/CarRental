namespace CarRental.DAL.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string PickupLocationName { get; set; }
        public string DropOffLocationName { get; set; }
        public bool Status { get; set; }
        public List<Car> Cars { get; set; }
        public List<CarRent> PickUpCarRents { get; set; } = new List<CarRent>();
        public List<CarRent> DropOffCarRents { get; set; } = new List<CarRent>();

    }
}
