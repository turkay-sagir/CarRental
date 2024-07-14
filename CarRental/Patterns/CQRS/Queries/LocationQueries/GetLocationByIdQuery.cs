namespace CarRental.Patterns.CQRS.Queries.LocationQueries
{
    public class GetLocationByIdQuery
    {
        public int LocationId { get; set; }

        public GetLocationByIdQuery(int locationId)
        {
            LocationId = locationId;
        }
    }
}
