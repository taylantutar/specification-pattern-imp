using specification_pattern_imp.model.Concrete;
using specification_pattern_imp.model.Specification;

namespace specification_pattern_imp.Repository
{
    public class StudentRepository
    {
        private List<Student> StudentList = new List<Student>();

        public StudentRepository()
        {
            StudentList. Add(new Student(){Name = "Ali", Surname = "Kaya", Age = 7, StudentLevel = Enums.StudentLevel.ONE});
            StudentList. Add(new Student(){Name = "Veli", Surname = "Kalkar", Age = 7, StudentLevel = Enums.StudentLevel.ONE});
            StudentList. Add(new Student(){Name = "Ayşe", Surname = "Yener", Age = 8, StudentLevel = Enums.StudentLevel.ONE});
            StudentList. Add(new Student(){Name = "Mehmet", Surname = "Akarsu", Age = 9, StudentLevel = Enums.StudentLevel.TWO});
            StudentList. Add(new Student(){Name = "Tekin", Surname = "", Age = 9, StudentLevel = Enums.StudentLevel.THREE});
        }

        public List<Student> StudentListByCriteria (ISpecification<Student> specification){
            return StudentList.Where(specification.ToFunc()).ToList();
        }
    }
}