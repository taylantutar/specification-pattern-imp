using specification_pattern_imp.Enums;
using specification_pattern_imp.model.Abstract;

namespace specification_pattern_imp.model.Concrete
{
    public class Student : IEntity
    {
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public short Age { get; set; }
        public StudentLevel StudentLevel { get; set; }
    }
}