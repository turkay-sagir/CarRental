using CarRental.Patterns.Mediator.Results;
using MediatR;

namespace CarRental.Patterns.Mediator.Queries
{
    public class GetCarByIdQuery:IRequest<GetCarByIdQueryResult>
    {
        public int CarId { get; set; }

        public GetCarByIdQuery(int carId)
        {
            CarId = carId;
        }
    }
}
