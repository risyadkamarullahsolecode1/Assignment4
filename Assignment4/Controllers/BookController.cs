using Assignment4.Models;
using Assignment4.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            return Ok(await _bookRepository.GetAllBooks());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            var createdBook = await _bookRepository.AddBook(book);
            return CreatedAtAction(nameof(AddBook), createdBook);
        }

        [HttpPut]
        public async Task<ActionResult<Book>> UpdateBook(int id, Book book)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var updatedBook = await _bookRepository.UpdateBook(book);
            if (updatedBook == null)
            {
                return NotFound();
            }
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteBook(int id)
        {
            var deleted = await _bookRepository.DeleteBook(id);
            if (!deleted)
            {
                return BadRequest();
            }
            return Ok("Buku Telah Dihapus");
        }
    }
}
