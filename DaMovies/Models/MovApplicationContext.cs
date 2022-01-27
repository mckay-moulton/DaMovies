using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaMovies.Models
{
    public class MovApplicationContext : DbContext
    {
        public MovApplicationContext (DbContextOptions<MovApplicationContext> anyname) : base (anyname)
        {
            //leave blank for now
        }

        public DbSet<FormClass> reponse { get; set; }

        protected override void OnModelCreating(ModelBuilder some_name)
        {
            some_name.Entity<FormClass>().HasData(

                new FormClass
                {
                    MovieID = 1,
                    Category = "Action",
                    Title = "The Blindside",
                    Year = 2012,
                    Director = "Steve Jacobs",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Jacob Marley",
                    Notes = "na"
                },

                new FormClass
                {
                    MovieID = 2,
                    Category = "Action",
                    Title = "The Dark Knight",
                    Year = 2012,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "Jacob Marley",
                    Notes = "na"
                },

                new FormClass
                {
                    MovieID = 3,
                    Category = "Romance",
                    Title = "The Proposal",
                    Year = 2009,
                    Director = "Anne Fletcher",
                    Rating = "PG-13",
                    Edited = false,
                    Lent_To = "na",
                    Notes = "na"
                }

                );

        }
    }
}
