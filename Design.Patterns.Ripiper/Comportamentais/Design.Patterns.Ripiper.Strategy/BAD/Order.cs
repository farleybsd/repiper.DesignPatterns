using System.Security.AccessControl;

namespace Design.Patterns.Ripiper.Strategy.BAD;

// Classe que representa o Pedido
public class Order
{
    public double Weight { get; set; }
    public string Destination { get; set; }
}
// Classe que calcula o frete com a logica condicional embutida
public class ShippingCostCalculator
{
    public double CalculateShippingCost(Order order)
    {
        if (order.Destination == "Local")
        {
            return order.Weight * 0.5;
        }
        else if (order.Destination == "Nacional")
        {
            return order.Weight * 0.75;
        }
        else if (order.Destination == "Internacional")
        {
            return order.Weight * 1.5;
        }
        else
        {
            throw new ArgumentException("Destino Desconhecido");
        }
    }
}