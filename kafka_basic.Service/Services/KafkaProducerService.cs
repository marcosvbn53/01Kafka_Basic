
using kafka_basic.Service.Messages;
using MassTransit;

namespace kafka_basic.Service.Services;

public class KafkaProducerService
{
    private readonly ITopicProducer<KafkaMessage> _producer;

    public KafkaProducerService(ITopicProducer<KafkaMessage> producer)
    {
        _producer = producer;
    }

    public async Task EnviarMensagemAsync(string conteudo)
    {
        var mensagem = new KafkaMessage
        {
            Conteudo = conteudo
        };

        await _producer.Produce(mensagem);
    }
}