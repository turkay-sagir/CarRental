using CarRental.DAL.Context;
using CarRental.Patterns.CQRS.Handlers.BrandHandlers;
using CarRental.Patterns.CQRS.Handlers.LocationHandlers;
using CarRental.Patterns.Mediator.Commands;
using CarRental.Patterns.Mediator.Handlers;
using CarRental.Patterns.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarRental.Controllers
{

    public class CarsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly CarContext _context;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;

        public CarsController(IMediator mediator, CarContext context, GetBrandQueryHandler getBrandQueryHandler, GetLocationQueryHandler getLocationQueryHandler)
        {
            _mediator = mediator;
            _context = context;
            _getBrandQueryHandler = getBrandQueryHandler;
            _getLocationQueryHandler = getLocationQueryHandler;
        }

        public async Task<IActionResult> CarList()
        {
            var values = await _mediator.Send(new GetCarQuery());
            return View(values);
        }

        public async Task<IActionResult> RemoveCar(int id)
        {
            await _mediator.Send(new RemoveCarCommand(id));
            return RedirectToAction("CarList");
        }

        [HttpGet]
        public async Task<IActionResult> CreateCar()
        {
            ViewBag.locationList = new SelectList(_getLocationQueryHandler.Handle(), "LocationId", "LocationName");
            ViewBag.brandList = new SelectList(_getBrandQueryHandler.Handle(), "BrandId", "BrandName");
            var model = new CreateCarCommand();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("CarList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            ViewBag.locationList = new SelectList(_getLocationQueryHandler.Handle(), "LocationId", "LocationName");
            ViewBag.brandList = new SelectList(_getBrandQueryHandler.Handle(), "BrandId", "BrandName");
            var value = await _mediator.Send(new GetCarByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("CarList");
        }

        public async Task<IActionResult> ChangeCarStatus(int id)
        {
            var value = _context.Cars.Find(id);

            if(value.Status==true)
            {
                value.Status = false;
            }

            else
            {
                value.Status = true;
            }

            _context.SaveChanges();
            return RedirectToAction("CarList");

        }
    }
}
