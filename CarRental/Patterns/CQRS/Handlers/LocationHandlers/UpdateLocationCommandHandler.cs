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
            var value = _context.Locations.Find(command.LocationId);
            value.LocationName = command.LocationName;
            value.Status = command.Status;
            _context.SaveChanges();
        }

    }
}
