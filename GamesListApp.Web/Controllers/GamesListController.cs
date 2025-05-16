using GamesListApp.Web.Services;
using GamesListApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesListApp.Web.Controllers
{
    public class GamesListController : Controller
    {
        static GamesListService gamesListService = new GamesListService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var games = gamesListService.GetAllGames();
            return View(games);
        }

        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                gamesListService.AddGame(game);
                return RedirectToAction("Index");
            }
            return View(game);
        }

    }
}
