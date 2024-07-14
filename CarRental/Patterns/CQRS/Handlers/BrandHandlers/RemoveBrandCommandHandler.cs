using CarRental.DAL.Context;
using CarRental.Patterns.CQRS.Commands.BrandCommands;

namespace CarRental.Patterns.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly CarContext _context;

        public RemoveBrandCommandHandler(CarContext context)
        {
            _context = context;
        }

        public void Handle(RemoveBrandCommand command)
        {
            var value = _context.Brands.Find(command.BrandId);
            _context.Brands.Remove(value);
            _context.SaveChanges();
        }
    }
}
