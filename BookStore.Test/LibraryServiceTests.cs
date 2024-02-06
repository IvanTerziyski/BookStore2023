using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.Repositories;
using BookStore.Models.Models;
using Moq;

namespace BookStore.Test
{
    public class LibraryServiceTests
    {
        public static List<Book> BookData = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Book 1",
                AuthorId = 1,
                ReleaseDate = new DateTime(2005,05,07)
            },
            new Book()
            {
                Id = 2,
                Title = "Book 2",
                AuthorId = 2,
                ReleaseDate = new DateTime(2009,06,25)
            },
            new Book()
            {
                Id = 3,
                Title = "Book 3",
                AuthorId = 3,
                ReleaseDate = new DateTime(2015,10,10)
            },
            new Book()
            {
                Id = 4,
                Title = "Book 4",
                AuthorId = 1,
                ReleaseDate = new DateTime(2007,05,07)
            },
        };
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "John Wayne",
                Bio = "Born in 1977, he published his first book in 1999, winning an award for his ingenious writing"
            },
            new Author()
            {
                Id = 2,
                Name = "Bill Smith",
                Bio = "Born in a family of musicians, Bill decided not to follow in his parents' footsteps, whichled to him becoming one of the biggest writers in today's society."
            },
            new Author()
            {
                Id = 3,
                Name = "Giuseppe Lombardy",
                Bio = "An Italian immigrant, moving to America, he was mesmorised by their culture, which led to his award-winning autobiography - A boot in American soil"
            },
        };
        [Fact]
        public void CheckBookCount_OK()
        {
            //setup
            var input = 10;
            var expectedCount = 14;

            var mockedBookRepository =
                new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooks()).Returns(BookData);

            //inject
            var bookService = new BookService(mockedBookRepository.Object);
            var authorService = new AuthorService(new AuthorRepository());
            var service = new LibraryService(authorService, bookService);

            //act
            var result = service.CheckBookCount(input);

            //Assert
            Assert.Equal(expectedCount, result);

        }
        [Fact]
        public void CheckBookCount_NegativeInput()
        {
            //setup
            var input = -10;
            var expectedCount = 0;

            var mockedBookRepository =
                new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooks()).Returns(BookData);

            //inject
            var bookService = new BookService(mockedBookRepository.Object);
            var authorService = new AuthorService(new AuthorRepository());
            var service = new LibraryService(authorService, bookService);

            //act
            var result = service.CheckBookCount(input);

            //Assert
            Assert.Equal(expectedCount, result);

        }
    }
}