using BookStore.DL.Configs;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Microsoft.Extensions.Options;

namespace BookStore.DL.Repositories.Mongo
{
    public class BookRepositoryMongo : IBookRepository
    {
        public IOptionsMonitor<MongoConfiguration> _mongoConfig;
        public BookRepositoryMongo(IOptionsMonitor<MongoConfiguration> mongoConfig)
        {
            _mongoConfig = mongoConfig;
        }
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public Book? GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
