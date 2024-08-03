using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
