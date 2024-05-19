using BookStore.Models.Models;
using BookStore.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BookStore.BL.Services;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookProducerController : ControllerBase
    {
        private readonly IBookProducerService _bookProducerService;
        public BookProducerController(IBookProducerService bookProducerService)
        {
            _bookProducerService = bookProducerService;
        }
        
        [HttpPost("AddBookFromProducer")]
        public async Task<IActionResult> ProduceBook([FromBody] Book book)
        {
            if (book == null) return BadRequest(book);
            await _bookProducerService.ProduceBook(book);
            return Ok(book);
        }
    }
}
