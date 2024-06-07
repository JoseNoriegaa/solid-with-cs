using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    readonly IStudentRepository studentRepository;
    readonly ILogbook logbook;

    public StudentController(IStudentRepository repository, ILogbook logbook)
    {
        this.studentRepository = repository;
        this.logbook = logbook;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        this.logbook.Add("returning student's list");
        return this.studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        this.studentRepository.Add(student);
        logbook.Add($"The Student {student.FullName} has been added");
    }
}
