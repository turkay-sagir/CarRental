using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.DefaultViewComponents
{
    public class _DefaultTestimonialsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
