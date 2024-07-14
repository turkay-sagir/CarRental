using CarRental.DAL.Context;
using CarRental.Patterns.CQRS.Commands.LocationCommands;

namespace CarRental.Patterns.CQRS.Handlers.LocationHandlers
{
    public class RemoveLocationCommandHandler
    {
        private readonly CarContext _context;

        public RemoveLocationCommandHandler(CarContext context)
        {
            _context = context;
        }

        public void Handle(RemoveLocationCommand command)
        {
            var value = _context.Locations.Find(command.LocationId);
            _context.Locations.Remove(value);
            _context.SaveChanges();
        }
    }
}
