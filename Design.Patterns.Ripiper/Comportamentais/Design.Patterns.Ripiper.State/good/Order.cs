namespace Design.Patterns.Ripiper.State.good;

//interface que define o contrato pata os estados
public interface IOrderState
{
    void ProcessOrder(Order order);
    void ShipOrder(Order order);
    void DeliverOrder(Order order);
}

// Classe Que Representa o Pedido
public class Order
{
    private IOrderState _currentState;

    public Order()
    {
        _currentState = new NewOrderState();
    }

    public void SetState(IOrderState state)
    {
        _currentState = state;
    }

    public void ProcessOrder()
    {
        _currentState.ProcessOrder(this);
    }

    public void ShipOrder()
    {
        _currentState.ShipOrder(this);
    }

    public void DeliverOrder()
    {
        _currentState.DeliverOrder(this);
    }
}
// Estado Novo
public class NewOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
       Console.WriteLine("Processando o pedido");
       order.SetState(new ProcessingOrderState());
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("P pedido presisa ser processado antes de ser enviado");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("O pedido presisa ser enviado antes de ser entregue");
    }
}
// Esrado Processando
public class ProcessingOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("P pedido ja esta sendo processado");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("Enviando o pedido");
        order.SetState(new ShipperOrderState());
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("O Pedido precisa ser enviado antes de ser entregue");
    }
}
// Estado Enviado
public class ShipperOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("O Pedido ja foi processado");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("O Pedido ja foi enviado");
    }

    public void DeliverOrder(Order order)
    {
        Console.WriteLine("O Entregando o Pedido");
        order.SetState(new DeliveryOrderState());
    }
}
//Estado ENTREGUE
public class DeliveryOrderState : IOrderState
{
    public void ProcessOrder(Order order)
    {
        Console.WriteLine("O Pedido ja foi entregue");
    }

    public void ShipOrder(Order order)
    {
        Console.WriteLine("O Pedido ja foi entregue");
    }

    public void DeliverOrder(Order order)
    {
        throw new NotImplementedException();
    }
}