using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IAuthorService
    {
        Task AddAuthor(Author author);

        Task DeleteAuthor(int id);

        Task UpdateAuthor(Author author);

        Task<Author?> GetAuthor(int id);

        Task<List<Author>> GetAllAuthors();
    }
}
