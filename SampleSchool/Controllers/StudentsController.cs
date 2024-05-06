using Microsoft.AspNetCore.Mvc;
using SampleSchool.Models;
using SampleSchool.Repositories;

namespace SampleSchool.Controllers;

[ApiController]
[Route("api/[controller]")] //ensures all endpoints share the same name
public class StudentsController : ControllerBase
{

    private readonly IStudentRepository _studentRepository;

    public StudentsController( IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
   }

    [HttpGet("getStudents")]
    public ActionResult GetStudents()
    {
        List<Student> students = _studentRepository.GetAll().ToList();
        return Ok(students);
    }

    [HttpGet("getStudentById/{id}")]
    public string GetStudentById([FromRoute] int id ) //from route ensures it comes from the route
    {
        return "Getting one student";
    }

    [HttpPost("addStudent")]
    public string AddStudent()
    {
        return "Add student";
    }
}