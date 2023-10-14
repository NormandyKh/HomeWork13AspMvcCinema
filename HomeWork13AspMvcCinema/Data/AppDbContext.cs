using Microsoft.EntityFrameworkCore;
using MovieData.Models;

namespace HomeWork13AspMvcCinema.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public  DbSet<Movie> Movies { get; set; }
    }
}
