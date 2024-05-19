using BookStore.DL.Serialization;
using BookStore.Models.Models;
using Confluent.Kafka;

namespace BookStore.DL.Kafka
{
    public class KafkaProducer
    {
        private static IProducer<Guid, Book>? _producer;

        public KafkaProducer()
        {
            var config = new ProducerConfig()
            {
                BootstrapServers = "sulky.srvs.cloudkafka.com:9094",
                SecurityProtocol = SecurityProtocol.SaslSsl,
                SaslUsername = "wrlgoryr",
                SaslPassword = "cfcSFJUaHz7tVE-wButfZIb51GTR-3lx",
                SaslMechanism = SaslMechanism.ScramSha512
            };
            _producer = new ProducerBuilder<Guid, Book>(config)
               .SetKeySerializer(new MsgPackSerializer<Guid>())
               .SetValueSerializer(new MsgPackSerializer<Book>())
           .Build();
           
        }

            public void Produce(Book  message)
            {
                _producer.Produce("wrlgoryr-pu-chat", new Message<Guid, Book> {Key = message.Id, Value = message});
            }
    }
}
