using ExampleWeb.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleWeb.Migrations.Data
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options) { }

        public virtual DbSet<Example> Examples { get; set; }
    }
}
