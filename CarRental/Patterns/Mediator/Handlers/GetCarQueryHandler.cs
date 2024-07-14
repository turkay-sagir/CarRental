using AutoMapper;
using CarRental.DAL.Context;
using CarRental.Patterns.Mediator.Queries;
using CarRental.Patterns.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, GetCarQueryResult>
    {
        private readonly CarContext _context;
        private readonly IMapper _mapper;

        public GetCarQueryHandler(CarContext context)
        {
            _context = context;
        }

        public async Task<GetCarQueryResult> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Cars.ToListAsync();
            return _mapper.Map<GetCarQueryResult>(value);
        }
    }
}
