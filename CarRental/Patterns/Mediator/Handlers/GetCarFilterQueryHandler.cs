using CarRental.DAL.Context;
using CarRental.Patterns.Mediator.Queries;
using CarRental.Patterns.Mediator.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Patterns.Mediator.Handlers
{
    public class GetCarFilterQueryHandler : IRequestHandler<GetCarFilterQuery, List<GetCarFilterQueryResult>>
    {
        private readonly CarContext _carContext;

        public GetCarFilterQueryHandler(CarContext carContext)
        {
            _carContext = carContext;
        }

        public async Task<List<GetCarFilterQueryResult>> Handle(GetCarFilterQuery request, CancellationToken cancellationToken)
        {
            var values = _carContext.Cars.Where(x => x.BrandId == request.BrandId && x.LocationId == request.PickUpLocationId);
            return await values.Select(x=> new GetCarFilterQueryResult
            {
                Price = x.Price,
                ImageUrl = x.ImageUrl,
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
                Year = x.Year

            }).ToListAsync();
        }
    }
}
