using Microsoft.AspNetCore.Mvc;

namespace CarRental.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
