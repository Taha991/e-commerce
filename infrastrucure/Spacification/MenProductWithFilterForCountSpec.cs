using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Spacification
{
    public class MenProductWithFilterForCountSpec : BaseSpacification<MenProducts>
    {
        public MenProductWithFilterForCountSpec(MenProductSpecPrams menProductSpec)
            : base(x =>
             (string.IsNullOrEmpty(menProductSpec.Search) || x.Name.ToLower().Contains(menProductSpec.Search)) &&
             (!menProductSpec.brandId.HasValue || x.MenProductBrandId == menProductSpec.brandId) &&
             (!menProductSpec.typeId.HasValue || x.MenProductTypeId == menProductSpec.typeId)
            )
        {
            
        }
    }
}
