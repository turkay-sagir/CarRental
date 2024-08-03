using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Commands.LocationCommands;

namespace CarRental.Patterns.CQRS.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandler
    {
        private readonly CarContext _context;

        public CreateLocationCommandHandler(CarContext context)
        {
            _context = context;
        }

        public void Handle(CreateLocationCommand command)
        {
            _context.Locations.Add(new Location
            {
                LocationName = command.LocationName,
                Status = true
            });
            _context.SaveChanges();
        }

    }
}
