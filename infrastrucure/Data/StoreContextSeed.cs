using Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace infrastrucure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            try
            {
                if (!context.MenProductBrands.Any())
                {
                    var menBrandsData = File.ReadAllText("../infrastrucure/Data/SeedData/menBrands.json");
                    var menBrands = JsonSerializer.Deserialize<List<MenProductBrand>>(menBrandsData);
                    context.MenProductBrands.AddRange(menBrands);
                }

                if (!context.MenProductTypes.Any())
                {
                    var menTypesData = File.ReadAllText("../infrastrucure/Data/SeedData/menTypes.json");
                    var menTypes = JsonSerializer.Deserialize<List<MenProductType>>(menTypesData);
                    context.MenProductTypes.AddRange(menTypes);
                }

                if (!context.MenProducts.Any())
                {
                    var menProductsData = File.ReadAllText("../infrastrucure/Data/SeedData/menProduct.json");
                    var menProducts = JsonSerializer.Deserialize<List<MenProducts>>(menProductsData);
                    context.MenProducts.AddRange(menProducts);
                }

                if (!context.WomenProductBrands.Any())
                {
                    var womenBrandsData = File.ReadAllText("../infrastrucure/Data/SeedData/womenBrands.json");
                    var womenBrands = JsonSerializer.Deserialize<List<WomenProductBrand>>(womenBrandsData);
                    context.WomenProductBrands.AddRange(womenBrands);
                }

                if (!context.WomenProductTypes.Any())
                {
                    var womenTypesData = File.ReadAllText("../infrastrucure/Data/SeedData/womenTypes.json");
                    var womenTypes = JsonSerializer.Deserialize<List<WomenProductType>>(womenTypesData);
                    context.WomenProductTypes.AddRange(womenTypes);
                }

                if (!context.WomenProducts.Any())
                {
                    var womenProductsData = File.ReadAllText("../infrastrucure/Data/SeedData/womenProduct.json");
                    var womenProducts = JsonSerializer.Deserialize<List<WomenProducts>>(womenProductsData);
                    context.WomenProducts.AddRange(womenProducts);
                }

                if (!context.FoodProductBrands.Any())
                {
                    var foodBrandsData = File.ReadAllText("../infrastrucure/Data/SeedData/foodBrands.json");
                    var foodBrands = JsonSerializer.Deserialize<List<FoodProductBrand>>(foodBrandsData);
                    context.FoodProductBrands.AddRange(foodBrands);
                }

                if (!context.FoodProductTypes.Any())
                {
                    var foodTypesData = File.ReadAllText("../infrastrucure/Data/SeedData/foodTypes.json");
                    var foodTypes = JsonSerializer.Deserialize<List<FoodProductType>>(foodTypesData);
                    context.FoodProductTypes.AddRange(foodTypes);
                }

                if (!context.FoodStuff.Any())
                {
                    var foodProductsData = File.ReadAllText("../infrastrucure/Data/SeedData/foodstuff.json");
                    var foodProducts = JsonSerializer.Deserialize<List<FoodStuff>>(foodProductsData);
                    context.FoodStuff.AddRange(foodProducts);
                }

                if (!context.HealthProductBrands.Any())
                {
                    var healthBrandsData = File.ReadAllText("../infrastrucure/Data/SeedData/healthBrands.json");
                    var healthBrands = JsonSerializer.Deserialize<List<HealthProductBrand>>(healthBrandsData);
                    context.HealthProductBrands.AddRange(healthBrands);
                }

                if (!context.HealthProductTypes.Any())
                {
                    var healthTypesData = File.ReadAllText("../infrastrucure/Data/SeedData/healthTypes.json");
                    var healthTypes = JsonSerializer.Deserialize<List<HealthProductType>>(healthTypesData);
                    context.HealthProductTypes.AddRange(healthTypes);
                }

                if (!context.HealthProducts.Any())
                {
                    var healthProductsData = File.ReadAllText("../infrastrucure/Data/SeedData/healthProduct.json");
                    var healthProducts = JsonSerializer.Deserialize<List<HealthProducts>>(healthProductsData);
                    context.HealthProducts.AddRange(healthProducts);
                }

                if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during seeding: {ex.Message}");
                Console.WriteLine($"Inner Exception: {ex.InnerException}");
            }

        }
    }
}
