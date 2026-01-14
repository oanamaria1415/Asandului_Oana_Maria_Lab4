using Microsoft.EntityFrameworkCore;
using Asandului_Oana_Maria_Lab4.Models;

namespace Asandului_Oana_Maria_Lab4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PredictionHistory> PredictionHistories { get; set; }
    }
}
