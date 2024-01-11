namespace BookStore.Models.Requests
{
    public class GetAllBookByAuthorRequest
    {
        public int AuthorId { get; set; }

        public DateTime DateAfter { get; set; }
    }
}
