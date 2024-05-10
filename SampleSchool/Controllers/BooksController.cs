using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleSchool.Context;
using SampleSchool.ModelDTos;
using SampleSchool.Models;

namespace SampleSchool.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly ApplicationContext _context;

    public BooksController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet("getBook/{id}")]
    public async Task<IActionResult> GetBook([FromRoute] int id)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == id);
        if (book == null)
        {
            return NotFound();
        }

        return Ok(book);
    }

    [HttpPost("addBook")]
    public async Task<IActionResult> AddBook([FromBody] BookListDto book)
    {
        if (ModelState.IsValid)
        {
            var newBook = new Book
            {
                name = book.name,
                publisher = book.publisher,
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return Ok();
        }

        return new JsonResult("Bad Request") { StatusCode = 400 };
    }

    [HttpPost("getBooks")]
    public async Task<IActionResult> GetBooks()
    {
        var books = await _context.Books.ToListAsync();
        return Ok(books);
    }
}