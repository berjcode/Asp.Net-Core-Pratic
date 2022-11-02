using Microsoft.AspNetCore.Mvc;
using Turkcell.Models;

namespace Turkcell.Controllers
{
    public class ProfileController : Controller
    {

        private Context _context;

        public ProfileController(Context context)
        {
           _context = context;
        }

        public IActionResult Index()
        {
           var profile = _context.Profiles.ToList();
            return View(profile);
           
        }
    }
}
