using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleSchool.Context;
using SampleSchool.ModelDTos;
using SampleSchool.Models;
using SampleSchool.Repositories;

namespace SampleSchool.Controllers;

[ApiController]
[Route("api/[controller]")] //ensures all endpoints share the same name
public class StudentsController : ControllerBase
{
    // private readonly IStudentRepository _studentRepository;
    private readonly ApplicationContext _context;

    public StudentsController(ApplicationContext context)
    {
        _context = context;
    }

    // public StudentsController(IStudentRepository studentRepository)
    // {
    //     _studentRepository = studentRepository;
    // }

    [HttpGet("getStudents")]
    public async Task<IActionResult> GetStudents(StudentListDto studentListDto)
    {
        var students = await _context.Students.ToListAsync();
        return Ok(students);
    }

    [HttpGet("getStudent/{id}")]
    public async Task<IActionResult> GetStudentById([FromRoute] int id) //from route ensures it comes from the route
    {
        var item = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpPost("addStudent")]
    public async Task<IActionResult> AddStudent([FromBody] StudentListDto student)
    {
        if (ModelState.IsValid)
        {
            var newStudent = new Student
            {
                firstName = student.firstName,
                lastName = student.lastName,
                feeBalance = student.feeBalance,
                gender = student.gender,
                dorm = student.dorm
            };
            await _context.Students.AddAsync(newStudent);
            await _context.SaveChangesAsync();
            return Ok();
        }

        return new JsonResult("Bad Request.") { StatusCode = 400 };
    }

    [HttpPut("editStudent{id}")]
    public async Task<IActionResult> UpdateStudent([FromRoute] int id, StudentUpdateDto student)
    {
        var newData = new Student
        {
            Id = student.Id,
            firstName = student.firstName,
            lastName = student.lastName,
            feeBalance = student.feeBalance,
            gender = student.gender,
            dorm = student.dorm
        };
        if (id != newData.Id)
        {
            return BadRequest();
        }

        var studentExists = await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
        if (studentExists == null)
        {
            return NotFound();
        }

        studentExists.firstName = newData.firstName;
        studentExists.lastName = student.lastName;
        studentExists.feeBalance = student.feeBalance;
        studentExists.gender = student.gender;
        studentExists.dorm = student.dorm;

        await _context.SaveChangesAsync();

        return NoContent();
    }
}