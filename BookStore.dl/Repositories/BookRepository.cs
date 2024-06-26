﻿using BookStore.DL.InMemoryDb;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;

namespace BookStore.DL.Repositories
{
    public class BookRepository //: IBookRepository
    {
        public void AddBook(Book book)
        {
            StaticData.Books.Add(book);
        }

        public void DeleteBook(Guid id)
        {
            var book = StaticData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null) return;
            StaticData.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return StaticData.Books;
        }

        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            return InMemoryDb.StaticData.Books
                    .Where(b => b.AuthorId == authorId)
                    .ToList();
        }

        public Book? GetBook(Guid id)
        {
            return StaticData.Books.FirstOrDefault(b => b.Id == id);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = StaticData.Books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook == null) return;

            StaticData.Books.Remove(existingBook);

            StaticData.Books.Add( new Book()
            {
                Id = existingBook.Id,
                Title = book.Title,
            });
        }
    }
}
