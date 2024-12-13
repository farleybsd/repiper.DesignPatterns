namespace Design.Patterns.Adapter.GOOD;

// Interface que define o servico de mensagens esperado pelo Sistema
public interface IMensageServiceGood
{
    public void Send(string mensagem);
}

// Servico de mensagem original que implementa a interface esperada
public class LegacyMensagemServiceGood : IMensageServiceGood
{
    public void Send(string message)
    {
        Console.WriteLine($"legacy message: {message}");
    }
}

// Novo Servico mensagens com uma interface diferente
public class NewMessageService
{
    public void SendNewMessage(string message)
    {
        Console.WriteLine($"new message service: {message}");
    }
}

// Adapter para o novo servico de mensagem, adaptando a interface para IMensageService
public class NewMessageServiceAdapter : IMensageServiceGood
{
    private readonly NewMessageService _newMessageService;

    public NewMessageServiceAdapter(NewMessageService newMessageService)
    {
        _newMessageService = newMessageService;
    }
    public void Send(string mensagem)
    {
        //Adaptando o metodo Send para usar o SendMessage Novo Servico
        _newMessageService.SendNewMessage(mensagem);
    }
}

// Sistema que usa o servico de mensagem com a interface IMessageSerice
public class AlertSystemGood
{
    private readonly IMensageServiceGood _mensageService;

    public AlertSystemGood(IMensageServiceGood mensageService)
    {
        _mensageService = mensageService;
    }

    public void SendAlert(string mensagem)
    {
        _mensageService.Send(mensagem);
    }
}