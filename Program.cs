
using specification_pattern_imp.model.Specification;
using specification_pattern_imp.Repository;

Console.WriteLine("Hello, World!");


var ageBiggerThanSpecification= new AgeBiggerThanSpecification(8);
var studentRepository = new StudentRepository();

var filteredStudents = studentRepository.StudentListByCriteria(ageBiggerThanSpecification);

Console.WriteLine("*****************");

foreach (var student in filteredStudents) Console.WriteLine($"{student.Name} {student.Surname} - {student.Age}");

Console.WriteLine(filteredStudents.Count);
Console.ReadKey();

