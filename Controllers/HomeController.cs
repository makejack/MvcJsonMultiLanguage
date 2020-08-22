using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace MvcJsonMultiLanguage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(new CultureInfo(culture))), new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddYears(1)
            });

            return LocalRedirect(returnUrl);
        }

        [HttpPost]
        public IActionResult AddTest()
        {

            return View();
        }
    }
}