using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Spacification
{
    public interface ISpacification<T>
    {   
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression <Func<T, object>>> Includes { get; }

        Expression<Func<T, object>> OrderByAsc { get; }
        Expression<Func<T, object>> OrderByDec { get; }
        int Take {  get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }


    }
}
