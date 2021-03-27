using BlazorAppHosted.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppHosted.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books {get; set;}

    }
}