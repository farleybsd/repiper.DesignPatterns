namespace Design.Patterns.mediator.GOOD;

// Interface Mediator que Define o Contrato para o mediador
public interface IchatRoomMediator
{
    void SendMessage(string message,ChatUser from,ChatUser toUser);
}

// Classe Concreta que Mediator que Decntralizar a comunicacao
public class chatRoom : IchatRoomMediator
{
    public void SendMessage(string message, ChatUser from, ChatUser toUser)
    {
        // Aqui a logica de comunicacao e centralizada no mediador
        Console.WriteLine($"{from.Name}: send message to : {toUser.Name} : {message}");
        toUser.ReceiveMessage(message, from);
    }
}

// Classe ChatUser que interage com o chatRoomMediator
public class ChatUser
{
    public string Name { get; }
    private readonly IchatRoomMediator _chatRoom;

    public ChatUser(string name, IchatRoomMediator chatRoom)
    {
        Name = name;
        _chatRoom = chatRoom;
    }
    // Metodo para enviar uma mensagem de outro usuario
    public void SendMessage(string message, ChatUser toUser)
    {
        _chatRoom.SendMessage(message,this, toUser);
    }

    // Metodo para receber uma mensagem de outro usuario
    public void ReceiveMessage(string message, ChatUser fromUser)
    {
        Console.WriteLine($"{Name}: received message to : {fromUser.Name} : {message}");
    }
}