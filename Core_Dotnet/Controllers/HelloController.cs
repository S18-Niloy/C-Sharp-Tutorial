using Microsoft.AspNetCore.Mvc;

namespace Core_Dotnet.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
