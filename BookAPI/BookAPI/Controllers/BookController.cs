using BookAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookDBContext _context;

        public BookController(BookDBContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public ActionResult GetBooks()
        {
            return Ok(_context.Books.ToArray());
        }

        [HttpGet("{id}")]
        public ActionResult GetBookByID(int id)
        {
            var bk = _context.Books.Find(id);
            if (bk == null) {
                return NotFound();
            }
            return Ok(bk);
        }

        [HttpGet("ByGenre/{id}")]

        public ActionResult GetBookByGenreId(string id)
        {
            var books = _context.Books
                .Where(book => book.GenreId == id)
                .ToArray();

            return Ok(books);

        }

        [HttpGet("ByAuthor/{id}")]

        public ActionResult GetBookByAuthorId(int id)
        {
            var books = _context.Books
                .Where(book => book.AuthorId == id)
                .ToArray();
           
            return Ok(books);

        }



        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
  
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetBooks",
                new { id = book.Id},
                book);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutBooks(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Books.Any(b => b.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var delBk = await _context.Books.FindAsync(id);
            if (delBk == null)
            {
                return NotFound();
            }

            _context.Books.Remove(delBk);
            await _context.SaveChangesAsync();

            return delBk;
        }


    }
}
