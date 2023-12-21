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
        public Book? GetBook(int id)
        {
            return _bookService.GetBook(id);
        }

        [HttpPost("Add")]
        public void AddBook([FromBody] Book book)
        {
            _bookService.AddBook(book);
        }

        [HttpDelete("Delete")]
        public void DeleteBook(int id) 
        { 
            _bookService.DeleteBook(id);
        }

        [HttpPost("Update")]
        public void UpdateBook([FromBody] Book book)
        {
            _bookService.UpdateBook(book);
        }

        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
        
    }
}
