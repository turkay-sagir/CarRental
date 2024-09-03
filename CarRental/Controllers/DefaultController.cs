using CarRental.Models;
using CarRental.Patterns.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace CarRental.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchCar(SearchCarViewModel _searchCarViewModel)
        {

            string dateFormat = "MM/dd/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;


            DateTime pickUpDate = DateTime.ParseExact(_searchCarViewModel.PickUpDate, dateFormat, provider);
            DateTime dropOffDate = DateTime.ParseExact(_searchCarViewModel.DropOffDate, dateFormat, provider);

            ViewBag.numberOfDay = dropOffDate.Day - pickUpDate.Day;

            if (_searchCarViewModel.BrandId > 0)
            {
                var values = await _mediator.Send(new GetCarFilterQuery(_searchCarViewModel));
                if (values.Count <= 0)
                {
                    ViewBag.carNotExist = "Aradığınız kriterlerde uygun araç bulunmamaktadır.";
                    return View(values);
                }
                else
                {
                    return View(values);
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
