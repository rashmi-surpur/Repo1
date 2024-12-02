using Microsoft.AspNetCore.Mvc;

namespace GitExample3.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index-V1.2");
        }

        public void Print()
        {
            //some code 
            int x = 10;
        }

        public void Display()
        {

        }
    }
}
