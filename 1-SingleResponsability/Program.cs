using SingleResponsibility.Repositories;
using SingleResponsibility.Helpers;

StudentRepository studentRepository = new();

var students = studentRepository.GetAll();

ExportHelper.ExportStudents(students);

Console.WriteLine("Proceso Completado");
