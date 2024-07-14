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
            _context.Brands.Update(new Brand
            {
                BrandName = command.BrandName,
            });
            _context.SaveChanges(); 
        }
    }
}
