namespace Design.Patterns.Adapter.BAD;

// Servico de Mensagem Original (Antigo)
public class LegacyMessageServiceBad
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"legacy message: {message}");
    }
}

// Sistema que usa o servico de mensagens (Novo)
public class AlerSystemBad
{
    private readonly LegacyMessageServiceBad _message; // Baixa Flexibilidade

    public AlerSystemBad(LegacyMessageServiceBad message) // Forte Acoplamento
    {
        _message = message;
    }

    public void SendAlert(string message)
    {
        _message.SendMessage(message);
    }
}