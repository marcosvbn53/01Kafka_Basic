namespace kafka_basic.Service.Messages;

public class KafkaMessage
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Conteudo { get; set; } = string.Empty;
    public DateTime DataEnvio { get; set; } = DateTime.UtcNow;
}