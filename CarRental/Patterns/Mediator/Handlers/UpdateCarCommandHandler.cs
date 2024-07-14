using AutoMapper;
using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.Mediator.Commands;
using MediatR;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly CarContext _context;
        private readonly IMapper _mapper;

        public UpdateCarCommandHandler(CarContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Car>(request);
            _context.Cars.Update(value);
            await _context.SaveChangesAsync();
        }
    }
}
