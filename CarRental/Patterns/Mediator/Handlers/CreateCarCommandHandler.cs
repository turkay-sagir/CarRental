using AutoMapper;
using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.Patterns.Mediator.Commands;
using MediatR;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        private readonly CarContext _context;
        private readonly IMapper _mapper;

        public CreateCarCommandHandler(CarContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<Car>(request);
            await _context.Cars.AddAsync(value);
            await _context.SaveChangesAsync();
        }
    }
}
