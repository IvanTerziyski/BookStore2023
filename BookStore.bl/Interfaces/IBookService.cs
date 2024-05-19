using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        public Task AddBook(Book book);

        public Task DeleteBook(Guid id);

        Task UpdateBook(Book book);

        Task<Book?> GetBook(Guid id);

        Task<List<Book>> GetAllBooksByAuthorAfterReleaseDate(int AuthorId, DateTime DateAfter);
        Task<List<Book>> GetAllBooks();
    }
}
