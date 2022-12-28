using Microsoft.AspNetCore.Mvc;

namespace CarRepair.Controllers
{
    public class ToyotaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
