using Ispit.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Ispit.API.Data
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options) { }

        public DbSet<ShoppingItem> ShoppingItems { get; set; }
    }
}