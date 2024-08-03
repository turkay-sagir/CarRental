using AutoMapper;
using CarRental.DAL.Entities;
using CarRental.Patterns.Mediator.Commands;
using CarRental.Patterns.Mediator.Results;

namespace CarRental.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, UpdateCarCommand>().ReverseMap();
            CreateMap<Car, GetCarByIdQueryResult>().ReverseMap();
        }
    }
}
