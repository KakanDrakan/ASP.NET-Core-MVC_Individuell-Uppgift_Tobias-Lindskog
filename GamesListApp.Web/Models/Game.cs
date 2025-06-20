﻿using GamesListApp.Web.Attributes;
using System.ComponentModel.DataAnnotations;

namespace GamesListApp.Web.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }
        public int? Rating { get; set; }
    }
}
