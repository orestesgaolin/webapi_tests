﻿
using System.ComponentModel.DataAnnotations;

namespace WebApiTests.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}