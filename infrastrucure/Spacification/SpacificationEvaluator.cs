using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Spacification
{
    public class SpacificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> InputQuery , ISpacification<TEntity> spec) 
        {
            var query = InputQuery;
            if(spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);

            }
            if(spec.OrderByAsc != null)
            {
                query.OrderBy(spec.OrderByAsc);
            }
            if(spec.OrderByDec != null)
            {
                query.OrderByDescending(spec.OrderByDec);
            }
            if (spec.OrderByAsc != null && spec.OrderByDec != null)
            {
                // Handle the case when both Ascending and Descending orders are specified
                throw new InvalidOperationException("Both Ascending and Descending orders are specified. Specify only one.");
            }
            if(spec.IsPagingEnabled)
            {
                query = query.Skip(spec.Skip).Take(spec.Take);
            }
            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include)); 
            return query;

        }

    }
}
