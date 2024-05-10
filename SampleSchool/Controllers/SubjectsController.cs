using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleSchool.Context;
using SampleSchool.ModelDTos;
using SampleSchool.Models;

namespace SampleSchool.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubjectsController : ControllerBase
{
    private readonly ApplicationContext _context;

    public SubjectsController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpPost("addSubject")]
    public async Task<IActionResult> AddSubject([FromBody] SubjectListDto subject)
    {
        if (ModelState.IsValid)
        {
            var newSubject = new Subject
            {
                name = subject.name,
                shortCode = subject.shortCode
            };
            await _context.Subjects.AddAsync(newSubject);
            await _context.SaveChangesAsync();
            return Ok();
        }

        return new JsonResult("Bad Request") { StatusCode = 400 };
    }

    [HttpGet("getSubjects")]
    public async Task<IActionResult> GetSubjects()
    {
        var subjects = await _context.Subjects.ToListAsync();
        return Ok(subjects);
    }
}