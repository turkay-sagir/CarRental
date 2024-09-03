using CarRental.DAL.Entities;
using CarRental.Models;
using CarRental.Patterns.Mediator.Results;
using MediatR;

namespace CarRental.Patterns.Mediator.Queries
{
    public class GetCarFilterQuery:IRequest<List<GetCarFilterQueryResult>>
    {
        public GetCarFilterQuery(SearchCarViewModel _searchCarViewModel)
        {
            BrandId = _searchCarViewModel.BrandId;
            PickUpLocationId = _searchCarViewModel.PickUpLocationId;
            DropOffLocationId = _searchCarViewModel.DropOffLocationId;
            PickUpDate = _searchCarViewModel.PickUpDate;
            DropOffDate = _searchCarViewModel.DropOffDate;
        }

        public int BrandId { get; set; }
        public int PickUpLocationId { get; set; }
        public int DropOffLocationId { get; set; }
        public string PickUpDate { get; set; }
        public string DropOffDate { get; set; }

    }
}
