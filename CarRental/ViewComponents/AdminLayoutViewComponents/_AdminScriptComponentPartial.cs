using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
