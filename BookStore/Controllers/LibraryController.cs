using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.BL.Validation;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;
using BookStore.Models.Requests;
using BookStore.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetAllBooksByAuthorAndDate")]
        public async Task<IActionResult>
             GetAllBooksByAuthorAndDate([FromBody] GetAllBookByAuthorRequest request)
        {
           var result = await _libraryService.GetAllBookByAuthorAfterReleaseDate(request);
            if (result == null) return NotFound();
            return Ok(result);
        }
        
}
 }