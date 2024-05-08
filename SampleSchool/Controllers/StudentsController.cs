using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleSchool.Context;
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
    public async Task<IActionResult> GetStudents()
    {
        var students = await _context.Students.ToListAsync();
        return Ok(students);
    }

    [HttpGet("getStudentById/{id}")]
    public async Task<IActionResult> GetStudentById([FromRoute] int id) //from route ensures it comes from the route
    {
        var item = await _context.Students.FirstOrDefault(x=> x.Id == id);
        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpPost("addStudent")]
    public async Task<IActionResult> AddStudent(Student data)
    {
        if (ModelState.IsValid)
        {
            await _context.Students.AddAsync(data);
            await _context.SaveChangesAsync();
            return Ok();
        }

        return new JsonResult("Bad Request.") { StatusCode = 400 };
    }
}