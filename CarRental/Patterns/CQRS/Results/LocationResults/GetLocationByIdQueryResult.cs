namespace CarRental.Patterns.CQRS.Results.LocationResults
{
    public class GetLocationByIdQueryResult
    {
        public int LocationId { get; set; }
        public string PickupLocationName { get; set; }
        public string DropOffLocationName { get; set; }
        public bool Status { get; set; }
    }
}
