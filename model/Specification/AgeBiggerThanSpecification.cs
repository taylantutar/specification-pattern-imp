using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using specification_pattern_imp.model.Concrete;

namespace specification_pattern_imp.model.Specification
{
    public class AgeBiggerThanSpecification : Specification<Student>
    {
        public int Age { get; set; }
        public AgeBiggerThanSpecification(int Age)
        {
            this.Age = Age;
        }

        public override Expression<Func<Student, bool>> ToExpression()
        {
            return student => student.Age >= this.Age;
        }
    }
}