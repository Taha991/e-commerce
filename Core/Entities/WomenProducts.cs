using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class WomenProducts : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public WomenProductType WomenProductType { get; set; }
        public int WomenProductTypeId { get; set; }
        public WomenProductBrand WomenProductBrand { get; set; }
        public int WomenProductBrandId { get; set; }
    }
}
