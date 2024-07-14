using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Results.LocationResults;

namespace CarRental.Patterns.CQRS.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler
    {
        private readonly CarContext _context;

        public GetLocationQueryHandler(CarContext context)
        {
            _context = context;
        }

        public List<GetLocationQueryResult> Handle()
        {
            return _context.Locations.Select(x=>new GetLocationQueryResult
            {
                LocationId = x.LocationId,
                DropOffLocationName = x.DropOffLocationName,
                PickupLocationName = x.PickupLocationName,
                Status = x.Status
            }).ToList();
        }
    }
}
