using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogNight.EntityLayer.Concrete;
using MyBlogNight.PresentationLayer.Models;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {                                                                   //LoginController da signinManager sınıfını kullan 
        private readonly SignInManager<AppUser> _signInManager;         //RegisterController da UserManager sınfını kullan

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            else
            {
                return View();
            }
        }
    }
}
