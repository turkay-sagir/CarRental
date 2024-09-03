using AutoMapper;
using CarRental.DAL.Entities;
using CarRental.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public RegisterController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {            
            var appUser = _mapper.Map<AppUser>(model);

            var result = await _userManager.CreateAsync(appUser, model.Password);

            if (result.Succeeded) 
            {
                return RedirectToAction("Index","Login");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View();
        }
    }
}
