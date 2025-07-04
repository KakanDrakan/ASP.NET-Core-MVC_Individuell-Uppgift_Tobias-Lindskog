﻿using GamesListApp.Web.Models;
using GamesListApp.Web.Views.GamesList;

namespace GamesListApp.Web.Services
{
    public class GamesListService
    {
        private List<Game> games = new List<Game>
        {
            new Game { Id = 1, Name = "The Legend of Zelda: Breath of the Wild", Publisher = "Nintendo", ReleaseYear = 2017, Rating = 8 },
            new Game { Id = 2, Name = "The Witcher 3: Wild Hunt", Publisher = "CD Projekt", ReleaseYear = 2015, Rating = 6 },
            new Game { Id = 3, Name = "Dark Souls", Publisher = "Bandai Namco Entertainment", ReleaseYear = 2011, Rating = 9}
        };

        public void AddGame(CreateVM viewModel)
        {
            var game = new Game
            {
                Name = viewModel.Name,
                Publisher = viewModel.Publisher,
                ReleaseYear = viewModel.ReleaseYear,
                Rating = viewModel.Rating
            };
            game.Id = games.Count == 0 ? 1 : games.Max(g => g.Id) + 1;
            games.Add(game);
        }

        public void RemoveGame(Game game)
        {
            games.Remove(game);
        }

        public IndexVM[] GetAllGames() => games.Select(g => new IndexVM
        {
            Id = g.Id,
            Name = g.Name,
            Publisher = g.Publisher,
            ReleaseYear = g.ReleaseYear,
            Rating = g.Rating
        }).ToArray();

        public Game GetGameById(int id)
        {
            return games.SingleOrDefault(g => g.Id == id);
        }

        public bool GameNameExists(string name)
        {
            return games.Any(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
