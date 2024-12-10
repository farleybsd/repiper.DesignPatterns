namespace Design.Patterns.Factory.Method.GOOD;

// Interface de Produto
public interface ITransport
{
    void Deliver();
}

// Implementacao de Produto Concretas
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Truck Deliver");
    }
}

// Implementacao de Produto Concretas
public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Ship Deliver");
    }
}

// Classe Criadora Abstrata
public abstract class Transport
{
    public abstract ITransport CreateTransport();

    public void Deliver()
    {
        var transporte = CreateTransport();
        transporte.Deliver();
    }
}

// SubClasses Concretas
public class TruckTransport : Transport
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}

// SubClasses Concretas
public class ShipTransport : Transport
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
