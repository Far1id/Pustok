using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pustok_Project.Areas.Manage.ViewModels;
using Pustok_Project.Models;
using System.Threading.Tasks;

namespace Pustok_Project.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        //private readonly SignInManager<AppUser> _signInManager;
        //private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager/*, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager*/)
        {
            _userManager = userManager;
            //_signInManager = signInManager;
            //_roleManager = roleManager;
        }

        //public async Task<IActionResult> CreateAdmin()
        //{
        //    AppUser admin = new AppUser 
        //    {
        //        Fullname = "Super Admin",
        //        UserName = "SuperAdmin"
        //    };

        //    var result = await _userManager.CreateAsync(admin, "Admin123");

        //    if (!result.Succeeded)
        //    {
        //        return Ok(result.Errors);
        //    }

        //    return View();
        //}


        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AdminLoginViewModel admin)
        {
            return Ok(admin);
        }
    }
}
