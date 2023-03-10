using Microsoft.EntityFrameworkCore;

namespace Sunlight_nursery_store.Data
{
    public class PlantDbContext :DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public string DbPath { get; set; }
        public PlantDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
                DbPath = System.IO.Path.Join(path, "Plants.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
               options.UseSqlite($"Data Source={DbPath}"); 
    }
}


