namespace Design.Patterns.mediator.BAD;
// Classe ChatUser representando um usuario no chat
public class ChatUser
{
    public string Name { get;}
    public ChatUser(string name)
    {
        Name = name;
    }

    // Metodo para enviar uma mensagem de outro usuario
    public void SendMessage(string message, ChatUser toUser)
    {
        Console.WriteLine($"{Name}: send message to : {toUser.Name} : {message}");
        toUser.ReceiveMessage(message, this);
    }

    // Metodo para receber uma mensagem de outro usuario
    public void ReceiveMessage(string message, ChatUser fromUser)
    {
        Console.WriteLine($"{Name}: received message to : {fromUser.Name} : {message}");
    }
}
