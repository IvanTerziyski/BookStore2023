using BookStore.Models.Models;

namespace BookStore.Models.Responses
{
    public class GetAllBookByAuthorResponse
    {
        public Author? Author { get; set; }
        public List<Book>? Books { get; set; }
    }
}
