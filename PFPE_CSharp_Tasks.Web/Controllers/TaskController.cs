using Microsoft.AspNetCore.Mvc;

namespace PFPE_CSharp_Tasks.Web.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        
        public IActionResult TaskOne()
        {
            return View();
        }  
        public IActionResult TaskTwo()
        {
            return View();
        }
    }
}
