namespace Design.Patterns.Ripiper.State.Bad;

//Classe que representa um Pedido
public class Order
{
    public string State { get;  set; }

    public Order()
    {
        State = "Novo";
    }
    public void ProcessOrder()
    {
        if (State == "Novo")
        {
            Console.WriteLine("Processando o Pedido");
            State = "Processando";
        }
        else if (State == "Processando")
        {
            Console.WriteLine("O  Pedido esta sendo processado");
        }
        else if (State == "Enviado")
        {
            Console.WriteLine("Pedido ja foi enviado");
        }
        else if (State == "Entregue")
        {
            Console.WriteLine("Pedido ja foi Entregue");
        }
    }

    public void ShipOrder()
    {
        if (State == "Processando")
        {
            Console.WriteLine("Enviado o Pedido");
            State = "Enviado";
        }
        else if (State == "Novo")
        {
            Console.WriteLine("O  Pedido esta sendo processado antes de ser enviado");
        }
        else if (State == "Enviado")
        {
            Console.WriteLine("Pedido ja foi enviado");
        }
        else if (State == "Entregue")
        {
            Console.WriteLine("Pedido ja foi Entregue");
        }
    }

    public void DeliverOrder()
    {
        if (State == "Enviado")
        {
            Console.WriteLine("Entregando o Pedido");
            State = "Entregue";
        }
        else if (State == "Novo" || State == "Processando")
        {
            Console.WriteLine("O  Pedido esta sendo processado antes de ser enviado");
        }
        
        else if (State == "Entregue")
        {
            Console.WriteLine("Pedido ja foi Entregue");
        }
    }
}

