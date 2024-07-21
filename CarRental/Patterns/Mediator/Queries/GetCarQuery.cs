using CarRental.Patterns.Mediator.Results;
using MediatR;

namespace CarRental.Patterns.Mediator.Queries
{
    public class GetCarQuery:IRequest<List<GetCarQueryResult>>
    {

    }
}
