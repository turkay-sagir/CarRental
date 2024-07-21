using CarRental.Patterns.CQRS.Commands.LocationCommands;
using CarRental.Patterns.CQRS.Handlers.BrandHandlers;
using CarRental.Patterns.CQRS.Handlers.LocationHandlers;
using CarRental.Patterns.CQRS.Queries.LocationQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class LocationsController : Controller
    {
        private readonly CreateLocationCommandHandler _createLocationCommandHandler;
        private readonly UpdateLocationCommandHandler _updateLocationCommandHandler;
        private readonly RemoveLocationCommandHandler _removeLocationCommandHandler;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;
        private readonly GetLocationByIdQueryHandler _getLocationByIdQueryHandler;

        public LocationsController(CreateLocationCommandHandler createLocationCommandHandler, UpdateLocationCommandHandler updateLocationCommandHandler, RemoveLocationCommandHandler removeLocationCommandHandler, GetLocationQueryHandler getLocationQueryHandler, GetLocationByIdQueryHandler getLocationByIdQueryHandler)
        {
            _createLocationCommandHandler = createLocationCommandHandler;
            _updateLocationCommandHandler = updateLocationCommandHandler;
            _removeLocationCommandHandler = removeLocationCommandHandler;
            _getLocationQueryHandler = getLocationQueryHandler;
            _getLocationByIdQueryHandler = getLocationByIdQueryHandler;
        }

        public IActionResult LocationList()
        {
            var values = _getLocationQueryHandler.Handle();
            return View(values);
        }

        public IActionResult RemoveLocation(int id)
        {
            _removeLocationCommandHandler.Handle(new RemoveLocationCommand(id));
            return RedirectToAction("LocationList");
        }

        [HttpGet]
        public IActionResult CreateLocation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLocation(CreateLocationCommand command)
        {
            _createLocationCommandHandler.Handle(command);
            return RedirectToAction("LocationList");
        }

        [HttpGet]
        public IActionResult UpdateLocation(int id)
        {
            var value = _getLocationByIdQueryHandler.Handle(new GetLocationByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateLocation(UpdateLocationCommand command)
        {
            _updateLocationCommandHandler.Handle(command);
            return RedirectToAction("LocationList");
        }

    }
}
