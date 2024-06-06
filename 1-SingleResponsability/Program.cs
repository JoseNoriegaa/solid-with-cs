using SingleResponsibility.Repositories;
using SingleResponsibility.Helpers;

StudentRepository studentRepository = new();

var students = studentRepository.GetAll();

ExportHelper.ExportCSV("Students", students);

Console.WriteLine("Proceso Completado");
