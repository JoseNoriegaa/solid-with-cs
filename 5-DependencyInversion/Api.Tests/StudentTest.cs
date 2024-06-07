using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;

namespace Api.Tests;


public class StudentTest 
{
    [Fact]
    public void GetStudent()
    {
        var logbookMock = new Mock<ILogbook>();
        var studentRepositoryMock = new Mock<IStudentRepository>();
        studentRepositoryMock.Setup(p=> p.GetAll())
                                        .Returns(new List<Student>()
                                        {
                                            new Student(1, "Pepito Pérez", [3, 4.5]),
                                            new Student(2, "Mariana Lopera", [4, 5]),
                                            new Student(3, "José Molina", [2, 3])
                                        });

        var studentController = new StudentController(studentRepositoryMock.Object, logbookMock.Object);

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

    [Fact]
    public void AddStudent()
    {
        var logbookMock = new Mock<ILogbook>();
        var studentRepositoryMock = new Mock<IStudentRepository>();

        var studentController = new StudentController(studentRepositoryMock.Object, logbookMock.Object);

        var student = new Student() {
            Id = 1,
            FullName = "John Doe",
            Grades = [10, 7]
        };

        studentController.Add(student);

        studentRepositoryMock.Verify(repo => repo.Add(It.IsAny<Student>()), Times.Once);
        logbookMock.Verify(logbook => logbook.Add($"The Student {student.FullName} has been added"), Times.Once);
    }
}
