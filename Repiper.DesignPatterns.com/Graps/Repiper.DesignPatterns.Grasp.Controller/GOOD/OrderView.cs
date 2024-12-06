namespace Repiper.DesignPatterns.Grasp.Controller.GOOD;

public class Order
{
    public string ProductId { get; set; }
    public int Quantity { get; set; }

    public Order(string productId, int quantity)
    {
        ProductId = productId;
        Quantity = quantity;
    }
}

public class OrderController
{
    public void ProcessOrder(Order order)
    {
        //Logica de processamento de pedido centralizada no controller
        Console.WriteLine($"Processing order for {order.ProductId} with quantity {order.Quantity}");
        // Simulacao de logica de processamento
        if (order.Quantity > 0)
        {
            Console.WriteLine("Order Processes Successfully");
        }
        else
        {
            Console.WriteLine("Invalid quantity");
        }
    }
}

public class OrderView
{
    private readonly OrderController _controller;

    public OrderView(OrderController controller)
    {
        _controller = controller;
    }

    public void OnSubmit(string productId, int quantity)
    {
        // Criacao do pedido de Delegaca do processamento ao controlador
        var order = new Order(productId, quantity);
        _controller.ProcessOrder(order);
    }
   
}