namespace DesingPatterns.Repiper.Decorator.BAD;

/*
 *  Esse exemplo uma hora ou outra ira alterar a classe de notificacao
 *  Proliferacao de sublasses
 *  Baixa Flexibilidade
 *  Dificuldade de manutencao
 */
// Classe base para notificacao
public class Notification
{
    public virtual void Send(string message)
    {
        Console.WriteLine($"Sending notification {message}");
    }
}
// Subclasse para notificacoes por email com criptografia
public class EncryptedEmailNotification : Notification
{
    public override void Send(string message)
    {
        string encryptedMessage = Encrypt(message);
        Console.WriteLine($"Sending encrypted email notification {encryptedMessage}");
    }

    private string Encrypt(string message)
    {
        return $"*****{message}******";
    }
}

// Subclasse para notificacoes por SMS com assinatura Digital
public class SignedSmSNotification : Notification
{
    public override void Send(string message)
    {
        string signedMessage = Sign(message);
        Console.WriteLine($"Sending signed sms notification {message}");
    }

    private string Sign(string message)
    {
        // Simulacao Assinatura Digital
        return $"{message} -- signed";
    }
}

