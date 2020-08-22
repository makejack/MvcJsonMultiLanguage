using Microsoft.AspNetCore.Mvc;
using MvcJsonMultiLanguage.Models;

namespace MvcJsonMultiLanguage.Controllers
{
    public class AccessController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {

            return View();
        }
    }
}