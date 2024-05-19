using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;

namespace BookStore.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _AuthorRepository;
        public AuthorService(IAuthorRepository AuthorRepository)
        {
            _AuthorRepository = AuthorRepository;
        }
        public async Task AddAuthor(Author Author)
        {
            await _AuthorRepository.AddAuthor(Author);
        }

        public async Task DeleteAuthor(int id)
        {
            await _AuthorRepository.DeleteAuthor(id);
        }

        public Task<List<Author>> GetAllAuthors()
        {
            return _AuthorRepository.GetAllAuthors();
        }

        public async Task<Author?> GetAuthor(int id)
        {
            return await _AuthorRepository.GetAuthor(id);
        }

        public async Task UpdateAuthor(Author Author)
        {
            await _AuthorRepository.UpdateAuthor(Author);
        }
    }
}
