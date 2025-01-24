

namespace Design.Patterns.Ripiper.Strategy.GOOD;

// Interface Strategy que Define o Contrato para as estrategias de calaculo de frete
public interface IShippingStrategy
{
    double CalculateShippingCost(Order order);
}
// Classe Concreta para o frete Local
public class LocalShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(Order order)
    {
        return order.Weight * 0.5;
    }
}
// Classe Concreta para o frete Nacional
public class NationallShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(Order order)
    {
        return order.Weight * 0.75;
    }
}
// Classe Concreta para o frete InterNacional
public class InterNationallShippingStrategy : IShippingStrategy
{
    public double CalculateShippingCost(Order order)
    {
        return order.Weight * 1.5;
    }
}

// Classe que representa o Pedido
public class Order
{
    public double Weight { get; set; }
    public string Destination { get; set; }
    public IShippingStrategy ShippingStrategy { get; set; }

    public double CalculateShippingCost()
    {
       return  ShippingStrategy.CalculateShippingCost(this);
    }
}