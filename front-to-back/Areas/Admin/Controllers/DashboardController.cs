using Microsoft.AspNetCore.Mvc;

namespace front_to_back.Areas.Admin.Controllers
{
    [Area("ADMIN")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
