using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.DefaultViewComponents
{
    public class _DefaultFeaturesComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
