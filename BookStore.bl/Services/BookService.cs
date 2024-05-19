using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository= bookRepository;
        }
        public async Task AddBook(Book book)
        {
            await _bookRepository.AddBook(book);
        }

        public async Task DeleteBook(Guid id)
        {
            await _bookRepository.DeleteBook(id);
        }

        public Task<List<Book>> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public async Task<List<Book>> GetAllBooksByAuthorAfterReleaseDate(int authorId, DateTime DateAfter)
        {
            var result = await _bookRepository.GetAllBooksByAuthor(authorId);
            return result.Where(b=>b.ReleaseDate >= DateAfter).ToList();
        }

        public async Task<Book?> GetBook(Guid id)
        {
            return await _bookRepository.GetBook(id);
        }

        public async Task UpdateBook(Book book)
        {
             await _bookRepository.UpdateBook(book);
        }
    }
}
