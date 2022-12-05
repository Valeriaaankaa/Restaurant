using Business.Interfaces;
using Data.Entities;
using Data.Interfaces;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Restaurant.Models;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IIngredientService _ingredientService;
        private readonly IDishService _dishService;

        public HomeController(ILogger<HomeController> logger, IIngredientService ingredientService, IDishService dishService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
            _dishService = dishService;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index(List<string> IngredientsIds)
        {
            return View(IngredientsIds);
        }
        
        public IActionResult Error()
        {
            var statusCode = HttpContext.Response.StatusCode;
            ViewData["statusCode"] = statusCode;
            var feauter = Request.HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            var path = feauter?.OriginalPath;
            return View("ErrorPage", new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                RequestedUrl = path,
                RedirectUrl = HttpContext.Request.GetDisplayUrl(),
                ExceptionMessage = ReasonPhrases.GetReasonPhrase(statusCode)
            });
        }
    }
}
