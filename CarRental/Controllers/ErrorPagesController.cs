using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Error401()
        {
            return View();
        }
    }
}
