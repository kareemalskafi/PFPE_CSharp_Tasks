using Microsoft.AspNetCore.Mvc;

namespace PFPE_CSharp_Tasks.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
