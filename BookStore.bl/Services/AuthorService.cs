using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
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
        public void AddAuthor(Author Author)
        {
            _AuthorRepository.AddAuthor(Author);
        }

        public void DeleteAuthor(int id)
        {
            _AuthorRepository.DeleteAuthor(id);
        }

        public List<Author> GetAllAuthors()
        {
            return _AuthorRepository.GetAllAuthors();
        }

        public Author? GetAuthor(int id)
        {
            return _AuthorRepository.GetAuthor(id);
        }

        public void UpdateAuthor(Author Author)
        {
            _AuthorRepository.UpdateAuthor(Author);
        }
    }
}
