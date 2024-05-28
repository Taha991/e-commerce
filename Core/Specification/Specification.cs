using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specification
{
    public interface Specification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderByAsc { get; }
        Expression<Func<T, object>> OrderByDec { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
