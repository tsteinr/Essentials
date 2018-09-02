using Microsoft.AspNetCore.Mvc;

namespace Essentials.Sample.Controllers
{
    [Route("~/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("Hello World", "application/json");
        }
    }
}
