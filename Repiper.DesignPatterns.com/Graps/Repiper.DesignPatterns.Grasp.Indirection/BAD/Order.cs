namespace Repiper.DesignPatterns.Grasp.Indirection.BAD;

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

public class InventoryService
{
    public bool CheckInventory(string product, int quantity)
    {
        // Simulacao de verificacao Inventario
        Console.WriteLine($"Checking inventory for product:{product} quantity:{quantity} ");
        return true;    
    }
}

public class OrderProcessor
{
    private InventoryService _inventoryService;

    public OrderProcessor()
    {
        _inventoryService = new InventoryService(); // Forte Acoplamento
    }

    public void ProcessOrder(Order order)
    {
        if (_inventoryService.CheckInventory(order.Product, order.Quantity))
        {
            Console.WriteLine("Order processed successfully");
        }
        else
        {
            Console.WriteLine("Order failed to process insufficient inventory");
        }
    }
}