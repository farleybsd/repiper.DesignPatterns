using System.Security.AccessControl;

namespace Repiper.DesignPatterns.Grasp.Indirection.GOOD;

public class Order
{
    public string Product { get; set; }
    public int Quantity { get; set; }

    public Order(string product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
}

// Interface  para Indirecao
public interface IIventorySercvice
{
    bool checkInventory(string product, int quantity);
}

public class InventorySercvice : IIventorySercvice
{
    public bool checkInventory(string product, int quantity)
    {
        // Simulacao de Verificacao de inventario
        Console.WriteLine($"Checking inventory for {product} , quantity {quantity}");
        return true;
    }
}

// Classe De Processamento
public class OrderProcessor
{
    private readonly IIventorySercvice _iInventorySercvice;

    public OrderProcessor(IIventorySercvice iInventorySercvice)
    {
        _iInventorySercvice = iInventorySercvice; // Baixo Acoplamento
    }

    public void ProcessOrder(Order order)
    {
        if (_iInventorySercvice.checkInventory(order.Product, order.Quantity))
        {
            Console.WriteLine("Order processed");
        }
    }
}