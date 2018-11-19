using System;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID {get; set; }

        public string title { get; set; }

        public DateTime releaseTime {get; set; }

        public decimal Price { get; set; }

    }

}