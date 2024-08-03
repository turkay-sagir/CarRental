using AutoMapper;
using CarRental.DAL.Context;
using CarRental.Patterns.Mediator.Commands;
using MediatR;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class RemoveCarCommandHandler : IRequestHandler<RemoveCarCommand>
    {
        private readonly CarContext _context; 

        public RemoveCarCommandHandler(CarContext context)
        {
            _context = context;
        }


        public async Task Handle(RemoveCarCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Cars.FindAsync(request.CarId);
            _context.Cars.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
