using BlazorApp2.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
