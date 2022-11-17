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

        

       public async Task<IActionResult> StockAsync(StockViewModel model)
        {
            IEnumerable<Ingredient> Ingredients = await _ingredientService.GetAllAsync();

            IEnumerable<IngredientGroup> Categories = Ingredients.Select(c => c.IngredientGroup).Distinct();

            IEnumerable<Ingredient> category_list;

            if (model.SelectSortType == IngredientSort.ByName)
            {
                category_list = Ingredients.Where(c => c.IngredientGroup.ToString() == model.Category).OrderBy(d => d.Name.ToLower());
            }
            else
            {
                category_list = Ingredients.Where(c => c.IngredientGroup.ToString() == model.Category).OrderBy(d => d.Amount);
            }

            var count = category_list.Count();
            var data = category_list.Skip(model.Page * model.PageSize).Take(model.PageSize).ToList();

            model.MaxPage = (count / model.PageSize) - (count % model.PageSize == 0 ? 1 : 0);
            model.Ingredients = data;
            model.Categories = Categories;

            return this.View(model);
        }


        public IActionResult Index(List<string> IngredientsIds)
        {



            return View(IngredientsIds);
        }
        
        public IActionResult Error()
        {
            var statusCode = HttpContext.Response.StatusCode;
            ViewData["statusCode"] = statusCode;
            var feauter = Request.HttpContext.Features.Get<IStatusCodeReExecuteFeature>();//=null
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
