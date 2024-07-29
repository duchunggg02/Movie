using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Movies
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Không được để trống!!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Không được để trống!!")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Không được để trống!!")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Không được để trống!!")]
        public decimal Price { get; set; }
    }
    public class MovieDbContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
    }
}