using AutoMapper;
using CarRental.DAL.Entities;
using CarRental.Models;
using CarRental.Patterns.CQRS.Commands.LocationCommands;
using CarRental.Patterns.CQRS.Results.BrandResults;
using CarRental.Patterns.CQRS.Results.LocationResults;
using CarRental.Patterns.Mediator.Commands;
using CarRental.Patterns.Mediator.Results;

namespace CarRental.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Car, GetCarQueryResult>().ReverseMap();
            CreateMap<Car, GetCarByIdQueryResult>().ReverseMap();
            CreateMap<Car, CreateCarCommand>().ReverseMap();
            CreateMap<Car, UpdateCarCommand>().ReverseMap();

            CreateMap<Location, GetLocationQueryResult>().ReverseMap();
            CreateMap<Location, GetLocationByIdQueryResult>().ReverseMap();
            CreateMap<Location, CreateLocationCommand>().ReverseMap();
            CreateMap<Location, UpdateLocationCommand>().ReverseMap();

            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();

            CreateMap<AppUser,RegisterViewModel>().ReverseMap();
        }
    }
}
