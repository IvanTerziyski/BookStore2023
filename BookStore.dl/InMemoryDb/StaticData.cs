using BookStore.Models.Models;

namespace BookStore.DL.InMemoryDb
{
    public static class StaticData
    {
        public static List<Book> Books = new List<Book>()
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
    }
}
