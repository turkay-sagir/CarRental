using AutoMapper;
using CarRental.DAL.Context;
using CarRental.Patterns.Mediator.Queries;
using CarRental.Patterns.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, List<GetCarQueryResult>>
    {
        private readonly CarContext _context;

        public GetCarQueryHandler(CarContext context)
        {
            _context = context;
        }

        public async Task<List<GetCarQueryResult>> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars.Select(x=>new GetCarQueryResult
            {
                BrandName = x.Brand.BrandName,
                CarId = x.CarId,
                Color = x.Color,
                EngineType = x.EngineType,
                HasABS = x.HasABS,
                HasAirConditioning = x.HasAirConditioning,
                HasBackupCamera = x.HasBackupCamera,
                HasBluetooth = x.HasBluetooth,
                HasGPS = x.HasGPS,
                HasLaneAssist = x.HasLaneAssist,
                HasParkingSensors = x.HasParkingSensors,
                HasSunroof = x.HasSunroof,
                Horsepower = x.Horsepower,
                LocationName = x.Location.LocationName,
                Mileage = x.Mileage,
                Model = x.Model,
                NumberOfAirbags = x.NumberOfAirbags,
                Transmission = x.Transmission,
                Year = x.Year,
                Status = x.Status
            }).ToListAsync();
        }
    }
}
