using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Spacification
{
    public class BaseSpacification<T> : ISpacification<T>
    {
        public BaseSpacification()
        {
            
        }
        public BaseSpacification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }

        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();

        public Expression<Func<T, object>> OrderByAsc { get; private set; }

        public Expression<Func<T, object>> OrderByDec { get; private set; }

        public int Take { get; private set; }

        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }

        protected void AddInculde(Expression<Func<T, object>>  includeExpression)
            {
             Includes.Add(includeExpression);
            }

        protected void AddOrderByAsc(Expression<Func<T, object>> orderByExpression)
        {
            OrderByAsc = orderByExpression;
        }
        protected void AddOrderByDec(Expression<Func<T, object>> orderByDecExpression)
        {
            OrderByDec = orderByDecExpression;
        }

        protected void ApplyPaging(int skip, int take)
        {
            Skip = skip; 
            Take = take;
            IsPagingEnabled = true;
        }


    }
}
