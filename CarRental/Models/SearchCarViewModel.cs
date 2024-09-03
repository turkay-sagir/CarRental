namespace CarRental.Models
{
    public class SearchCarViewModel
    {
        public int BrandId { get; set; }
        public int PickUpLocationId { get; set; }
        public int DropOffLocationId { get; set; }
        public string PickUpDate { get; set; }
        public string DropOffDate { get; set; }
    }
}
