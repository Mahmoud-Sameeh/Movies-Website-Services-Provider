using EcommerceApicore2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApicore2.Data
{
    public class ApplicationDbContext :IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Movie> Movies { set; get; }
        public DbSet<Studio> Studios { set; get; }
        public DbSet<Director> Directors { set; get; }
        public DbSet<MovieCharacter> MovieCharacters { set; get; }
        public DbSet<Actor> Actors { set; get; }
        public DbSet<Models.Type> Types { set; get; }
        public DbSet<Review> Reviews { set; get; }
        public DbSet<Category> Categorys { set; get; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Models.Type>(v =>
            {
                v.HasKey(v => v.Id);

            });
            builder.Entity<Actor>(v =>
            {
                v.HasKey(v => v.Id);

            });
            builder.Entity<Movie>(v =>
            {
                v.HasKey(v => v.Id);
                v.HasOne(v => v.Studio)
                 .WithMany(v => v.Movies);

                v.HasOne(v => v.Director)
                 .WithMany(v => v.Movies);

                v.HasMany(v => v.MovieCharacters)
                .WithOne(v => v.Movie);

                v.HasMany(v => v.Reviews)
                .WithOne(v => v.Movie);

                v.HasMany(z => z.Categories)
                .WithMany(z => z.Movies);
            });
        }
    }
}
