using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test.Models
{
    public partial class Movie : DbContext
    {
        public Movie()
            : base("name=Movie")
        {
        }

        public virtual DbSet<Movy> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movy>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
