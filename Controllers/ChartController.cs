using Microsoft.AspNetCore.Mvc;

namespace Turkcell.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
