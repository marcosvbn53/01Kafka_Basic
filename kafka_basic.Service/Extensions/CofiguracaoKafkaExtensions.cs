using kafka_basic.Service.Messages;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
namespace kafka_basic.Service.Extensions;

public static class ConfiguracaoKafkaExtensions
{
    public static void AddKafkaConfig(this IServiceCollection service)
    {
        service.AddMassTransit(px =>
        {
            px.AddRider(rider =>
            {
                rider.AddProducer<KafkaMessage>("kafica_basic");

                rider.UsingKafka((context, k) =>
                {
                    k.Host("localhost:9067");
                });
            });
        });
    }
}