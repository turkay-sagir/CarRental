using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Commands.BrandCommands;

namespace CarRental.Patterns.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly CarContext _context;

        public UpdateBrandCommandHandler(CarContext context)
        {
            _context = context;
        }

        public void Handle(UpdateBrandCommand command)
        {
            var value = _context.Brands.Find(command.BrandId);
            value.BrandName = command.BrandName;
            _context.SaveChanges(); 
        }
    }
}
