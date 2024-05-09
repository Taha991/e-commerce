using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class FoodStuff :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public FoodProductType FoodProductType { get; set; }
        public int FoodProductTypeId { get; set; }
        public FoodProductBrand FoodProductBrand { get; set; }
        public int FoodProductBrandId { get; set; }
    }
}
