using Microsoft.AspNetCore.Mvc;

namespace Recodetour.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
