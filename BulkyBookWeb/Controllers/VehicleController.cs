using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
