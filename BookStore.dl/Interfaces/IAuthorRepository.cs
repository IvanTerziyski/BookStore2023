using BookStore.Models.Models;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        public Task AddAuthor(Author author);


        public Task DeleteAuthor(int id);

        public Task UpdateAuthor(Author author);


        public Task<Author?> GetAuthor(int id);


        public Task<List<Author>> GetAllAuthors();
    }
}
