using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class HealthProducts :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public HealthProductType HealthProductType { get; set; }
        public int HealthProductTypeId { get; set; }
        public HealthProductBrand HealthProductBrand { get; set; }
        public int HealthProductBrandId { get; set; }
    }
}
