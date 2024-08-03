using AutoMapper;
using CarRental.DAL.Context;
using CarRental.Patterns.Mediator.Queries;
using CarRental.Patterns.Mediator.Results;
using MediatR;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        private readonly CarContext _context;
        private readonly IMapper _mapper;
        public GetCarByIdQueryHandler(CarContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Cars.FindAsync(request.CarId);

            return _mapper.Map<GetCarByIdQueryResult>(value);
        }
    }
}
