using Microsoft.AspNetCore.Mvc;

namespace Pustok_Project.Areas.Manage.Controllers
{
    [Area("manage")]
    public class DashboardController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
