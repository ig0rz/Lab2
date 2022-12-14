using IZavarykInIA.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IZavarykInIA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}

