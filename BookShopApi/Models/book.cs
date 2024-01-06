﻿namespace BookShopApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }
    }
}
