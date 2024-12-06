namespace Repiper.DesignPatterns.Grasp.Controller.BAD;

public class OrderView
{
    public void OnSubmtOrder(string prodctId, int quantity)
    {
        // Codigo de procesamento dentro da View
        Console.WriteLine($"Processing order for {prodctId} with quantity {quantity}");
        
        // Simulacao de logica de processamento
        if (quantity > 0)
        {
            Console.WriteLine("Order Processes Successfully");
        }
        else
        {
            Console.WriteLine("Invalid quantity");
        }
    }
}