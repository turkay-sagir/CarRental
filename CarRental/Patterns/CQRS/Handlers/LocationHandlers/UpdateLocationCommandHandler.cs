using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Commands.LocationCommands;

namespace CarRental.Patterns.CQRS.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler
    {
        private readonly CarContext _context;

        public UpdateLocationCommandHandler(CarContext context)
        {
            _context = context;
        }

        public void Handle(UpdateLocationCommand command)
        {
            _context.Locations.Update(new Location
            {
                PickupLocationName = command.PickupLocationName,
                DropOffLocationName = command.DropOffLocationName,
                Status = command.Status
            });
            _context.SaveChanges();
        }

    }
}
