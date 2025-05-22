using GamesListApp.Web.Services;
using GamesListApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using GamesListApp.Web.Views.GamesList;

namespace GamesListApp.Web.Controllers
{
    public class GamesListController(GamesListService gamesListService) : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            var viewModel = gamesListService.GetAllGames();
            return View(viewModel);
        }

        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(CreateVM viewModel)
        {
            if (ModelState.IsValid)
            {
                gamesListService.AddGame(viewModel);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

    }
}
