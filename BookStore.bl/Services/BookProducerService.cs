using BookStore.BL.Interfaces;
using BookStore.DL.Kafka;
using BookStore.Models.Models;

namespace BookStore.BL.Services
{
    public class BookProducerService : IBookProducerService 
    { 
        private static KafkaProducer? _producer;
        public BookProducerService()
        {
            _producer = new KafkaProducer();
        }

        public async Task ProduceBook(Book book)
        {
            _producer.Produce(book);
        }
    }
}
