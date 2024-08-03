using CarRental.DAL.Context;
using CarRental.Patterns.CQRS.Queries.LocationQueries;
using CarRental.Patterns.CQRS.Results.LocationResults;

namespace CarRental.Patterns.CQRS.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler
    {
        private readonly CarContext _context;

        public GetLocationByIdQueryHandler(CarContext context)
        {
            _context = context;
        }

        public GetLocationByIdQueryResult Handle(GetLocationByIdQuery query)
        {
            var value = _context.Locations.Find(query.LocationId);
            return new GetLocationByIdQueryResult
            {
                LocationId = value.LocationId,
                LocationName = value.LocationName,
                Status = value.Status
            };
        }
    }
}
