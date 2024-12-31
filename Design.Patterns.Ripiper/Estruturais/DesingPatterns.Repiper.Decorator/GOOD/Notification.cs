namespace DesingPatterns.Repiper.Decorator.GOOD;
/*
 *  Reducao da proliferacao de subclasses
 *  Alta Flexibilidade
 *  Facilidade de manutencao
 */
// Interface base para notificacoes
public abstract class Notification
{
    public abstract void Send(string message);
}
// Classe Concreta para notifcacoes simples
public class BasicNotification : Notification
{
    public override void Send(string message)
    {
        Console.WriteLine($"Sending notification {message}");
    }
}
// Classe Abstrata para decorator
public abstract class NotificationDecorator : Notification
{
    protected GOOD.Notification _notification;

    public NotificationDecorator(Notification notification)
    {
        _notification = notification;
    }

    public override void Send(string message)
    {
        _notification.Send(message);
    }
}

// Decorator concreto para Adicionar Criptografia 
public class EncryptedNotifcationDecorator : NotificationDecorator
{
    public EncryptedNotifcationDecorator(Notification notification) : base(notification)  { }

    public override void Send(string message)
    {
        string encryptedMessage = Encrypt(message);
        base.Send(encryptedMessage);
        
    }
    private string Encrypt(string message)
    {
        return $"*****{message}******";
    }
}
// Decorator Concreto para Adicionar Assinatura Digital
public class SignedSmSNotificationDecorator : NotificationDecorator
{
    public SignedSmSNotificationDecorator(Notification notification) : base(notification) { }

    public override void Send(string message)
    {
        string signedMessage = Sign(message);
        base.Send(signedMessage);
    }
    private string Sign(string message)
    {
        // Simulacao Assinatura Digital
        return $"{message} -- signed";
    }
}