using Microsoft.AspNetCore.Mvc;
using PFPE_CSharp_Tasks.Web.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;



namespace PFPE_CSharp_Tasks.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
           // ViewBag.WelcomeMessage = string.Format(_localizer["welcome"], "DevCreed");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }





        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
