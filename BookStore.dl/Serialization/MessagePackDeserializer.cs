using Confluent.Kafka;
using MessagePack;

namespace BookStore.DL.Serialization
{
    public class MessagePackDeserializer<T> : IDeserializer<T>
    {
        public T Deserialize(
            ReadOnlySpan<byte> data,
            bool isNull,
            SerializationContext context)
        {
            return 
                MessagePackSerializer
                    .Deserialize<T>(data.ToArray());
        }
    }
}
