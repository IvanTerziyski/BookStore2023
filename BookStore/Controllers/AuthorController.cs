using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _AuthorService;
        public AuthorController(IAuthorService AuthorService)
        {
            _AuthorService = AuthorService;
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("GetById")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            if (id < 0) return BadRequest(id);
            var result = await _AuthorService.GetAuthor(id);
            return result != null ? Ok(result) : NotFound(id);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAuthor([FromBody] Author author)
        {
            if (author == null) return BadRequest(author);
            await _AuthorService.AddAuthor(author);
            return Ok(author);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            if (id < 0) return BadRequest(id);
            await _AuthorService.DeleteAuthor(id);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAuthor([FromBody] Author author)
        {
            if (author == null) return BadRequest(author);
            await _AuthorService.UpdateAuthor(author);
            return Ok();
        }

        [HttpGet("GetAllAuthors")]
        public async Task<IActionResult> GetAllAuthors()
        {
            var result = await _AuthorService.GetAllAuthors();
            if (result != null && result.Count == 0) return NoContent();

            return Ok(result);

        }
    }
}
