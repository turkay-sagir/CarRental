using AutoMapper;
using CarRental.DAL.Entities;
using CarRental.Patterns.CQRS.Handlers.BrandHandlers;
using CarRental.Patterns.CQRS.Handlers.LocationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.DefaultViewComponents
{
    public class _DefaultCarFilterComponentPartial:ViewComponent
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;
        private readonly IMapper _mapper;

        public _DefaultCarFilterComponentPartial(GetBrandQueryHandler getBrandQueryHandler, GetLocationQueryHandler getLocationQueryHandler, IMapper mapper)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _getLocationQueryHandler = getLocationQueryHandler;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values1 = _getBrandQueryHandler.Handle();
            var result1 = _mapper.Map<List<Brand>>(values1);
            ViewBag.Brands = result1;
            
            var values2 = _getLocationQueryHandler.Handle();
            var result2 = _mapper.Map<List<Location>>(values2);
            ViewBag.Locations = result2;
            return View();
        }
    }
}
