using Microsoft.AspNetCore.Mvc;

namespace GitExample3.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index -V1.0");
        }
    }
}
