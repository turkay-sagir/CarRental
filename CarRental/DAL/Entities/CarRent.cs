using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DAL.Entities
{
    public class CarRent
    {
        public int CarRentId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int PickUpLocationId { get; set; }
        public Location PickUpLocation { get; set; }
        public int DropOffLocationId { get; set; }
        public Location DropOffLocation { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
