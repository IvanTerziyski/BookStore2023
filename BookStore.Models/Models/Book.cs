using MessagePack;

namespace BookStore.Models.Models
{

    [MessagePackObject]
    public class Book
    {
        [Key(0)]
        public Guid Id { get; set; }

        [Key(1)]
        public string Title { get; set; } = string.Empty;

        [Key(2)]
        public int AuthorId { get; set; }

        [Key(3)]
        public DateTime ReleaseDate { get; set; }

        [Key(4)]
        public string Sender { get; set; } = string.Empty;
    }
}
