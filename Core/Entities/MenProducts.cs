using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MenProducts :BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public MenProductType MenProductType { get; set; }
        public int MenProductTypeId { get; set; }
        public MenProductBrand MenProductBrand { get; set; }
        public int MenProductBrandId { get; set; }

    }
}
