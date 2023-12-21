using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthorStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _AuthorService;
        public AuthorController(IAuthorService AuthorService)
        {
            _AuthorService = AuthorService;
        }

        [HttpGet("GetById")]
        public Author? GetAuthor(int id)
        {
            return _AuthorService.GetAuthor(id);
        }

        [HttpPost("Add")]
        public void AddAuthor([FromBody] Author Author)
        {
            _AuthorService.AddAuthor(Author);
        }

        [HttpDelete("Delete")]
        public void DeleteAuthor(int id)
        {
            _AuthorService.DeleteAuthor(id);
        }

        [HttpPost("Update")]
        public void UpdateAuthor([FromBody] Author Author)
        {
            _AuthorService.UpdateAuthor(Author);
        }

        [HttpGet("GetAllAuthors")]
        public List<Author> GetAllAuthors()
        {
            return _AuthorService.GetAllAuthors();
        }

    }
}
