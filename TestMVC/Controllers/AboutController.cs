using Microsoft.AspNetCore.Mvc;

namespace TestMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
