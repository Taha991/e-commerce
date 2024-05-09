using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Spacification
{
    public class MenProductWithTypesAndBrandsSpacification : BaseSpacification<MenProducts>
    {
        public MenProductWithTypesAndBrandsSpacification(MenProductSpecPrams specPrams)
            : base(x =>
            (string.IsNullOrEmpty(specPrams.Search)|| x.Name.ToLower().Contains(specPrams.Search))&&
            (!specPrams.brandId.HasValue || x.MenProductBrandId == specPrams.brandId) &&
            (!specPrams.typeId.HasValue || x.MenProductTypeId == specPrams.typeId)
            )
        {
            AddInculde(x => x.MenProductType);
            AddInculde(x => x.MenProductBrand);
            AddOrderByAsc(x => x.Name);
            ApplyPaging(specPrams.PageSize * (specPrams.PageIndex-1) , specPrams.PageSize);

            if(!string.IsNullOrEmpty(specPrams.Sort))
            {
                switch(specPrams.Sort)
                {
                    case "priceAsc":
                        AddOrderByAsc(p=> p.Price); 
                        break;
                    case "priceDec":
                        AddOrderByDec(p=> p.Price);

                        break;
                    default:
                        AddOrderByAsc(p=> p.Name)
                            ; break;    

                }
            }
        }

        public MenProductWithTypesAndBrandsSpacification( int id) :base (x=> x.Id == id)
        {
            AddInculde(x => x.MenProductType);
            AddInculde(x => x.MenProductBrand);
        }
    }
}
