
using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IBookProducerService
    {
        public Task ProduceBook(Book book);
    }
}
