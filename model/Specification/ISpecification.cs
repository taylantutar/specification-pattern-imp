using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using specification_pattern_imp.model.Abstract;

namespace specification_pattern_imp.model.Specification
{
    public interface ISpecification<T> where T : IEntity
    {
         Expression<Func<T , bool>> ToExpression();
         Func<T , bool> ToFunc();
        bool IsSatisfiedBy(T entity);
    }
}