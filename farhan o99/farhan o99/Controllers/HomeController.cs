using Microsoft.AspNetCore.Mvc;

namespace farhan_o99.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
