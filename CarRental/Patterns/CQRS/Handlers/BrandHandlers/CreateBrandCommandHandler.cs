using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Commands.BrandCommands;

namespace CarRental.Patterns.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly CarContext _context;

        public CreateBrandCommandHandler(CarContext context)
        {
            _context = context;
        }

        public void Handle(CreateBrandCommand command)
        {
            _context.Brands.Add(new Brand
            {
                BrandName = command.BrandName
            });
            _context.SaveChanges();
        }
    }
}
