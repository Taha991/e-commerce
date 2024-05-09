using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace infrastrucure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        // Make DbSet properties public
        public DbSet<MenProducts> MenProducts { get; set; }
        public DbSet<MenProductType> MenProductTypes { get; set; }
        public DbSet<MenProductBrand> MenProductBrands { get; set; }
        public DbSet<WomenProducts> WomenProducts { get; set; }
        public DbSet<WomenProductType> WomenProductTypes { get; set; }
        public DbSet<WomenProductBrand> WomenProductBrands { get; set; }
        public DbSet<HealthProducts> HealthProducts { get; set; }
        public DbSet<HealthProductType> HealthProductTypes { get; set; }
        public DbSet<HealthProductBrand> HealthProductBrands { get; set; }
        public DbSet<FoodStuff> FoodStuff { get; set; }
        public DbSet<FoodProductType> FoodProductTypes { get; set; }
        public DbSet<FoodProductBrand> FoodProductBrands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
