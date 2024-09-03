using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.DefaultViewComponents
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
