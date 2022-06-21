using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pustok_Project.Areas.Manage.Controllers
{
    [Authorize(Roles ="SuperAdmin,Admin")]
    [Area("manage")]
    public class DashboardController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
