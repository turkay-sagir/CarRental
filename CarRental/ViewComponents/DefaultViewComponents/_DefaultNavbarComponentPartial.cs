using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
