using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetBook(Guid id)
        {

            if (id == Guid.Empty) return BadRequest(id);
            var result = await _bookService.GetBook(id);
            return result !=null ? Ok(result) : NotFound(id);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            if (book == null) return BadRequest(book);
            await _bookService.AddBook(book);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteBook(Guid id) 
        {
            if (id == Guid.Empty) return BadRequest(id);
            await _bookService.DeleteBook(id);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateBook([FromBody] Book book)
        {
            if(book == null) return BadRequest(book);
            await _bookService.UpdateBook(book);
            return Ok();
        }

        [HttpGet("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = await _bookService.GetAllBooks();
            if (result != null && result.Count == 0) return NoContent();

            return Ok(result);
            

        }
        
    }
}
