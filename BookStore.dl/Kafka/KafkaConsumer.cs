using BookStore.DL.Serialization;
using BookStore.Models.Models;
using Confluent.Kafka;

namespace BookStore.DL.Kafka
{
    public class KafkaConsumer
    {
        private static IConsumer<Guid, Book>? _consumer;
        private readonly string user;
        private bool _running = true;

        public KafkaConsumer(string user)
        {
            var cfg = new ConsumerConfig()
            {
                BootstrapServers = "pkc-7xoy1.eu-central-1.aws.confluent.cloud:9092",
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslUsername = "YWULFRPB3FUBKXZ6",
                SaslPassword = "3xYVjpimzsKS+XK5lYUYpG2kkQx7SIUTMFtMUdqwBJuocQWa4BzyCBbEOJroNVBf",
                SaslMechanism = SaslMechanism.Plain,
                GroupId = $"Boris.{Guid.NewGuid()}",
                AutoOffsetReset = AutoOffsetReset.Latest
            };

            _consumer = new ConsumerBuilder<Guid, Book>(cfg)
                .SetKeyDeserializer(new MessagePackDeserializer<Guid>())
                .SetValueDeserializer(new MessagePackDeserializer<Book>())
                .Build();

            var topics = new List<string>()
            {
                "pu-chat"
            };

            _consumer.Subscribe(topics);
            this.user = user;
        }
        public void Consume()
        {
            while (true)
            {
                var consumeResult = _consumer.Consume();
                if (consumeResult != null)
                {
                    var msg = new Book();
                    Console.WriteLine($"[{msg.Id}] [{msg.Title}] [{msg.AuthorId}] [{msg.ReleaseDate}] [{msg.Sender}]");
                }
            }

        }
    }
}
