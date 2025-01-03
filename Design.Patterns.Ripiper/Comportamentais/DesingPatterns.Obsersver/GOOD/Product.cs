namespace DesingPatterns.Obsersver.GOOD;

// Interface Observer que define o contrato para os observadores [Quem Ouve a mensagem]
public interface IObsersver
{
    void Updadte(string productName,decimal price);
}

// Interface Subject que define o contrato para o sujeito (Product) [Quem Gera a mensagem]
public interface ISubject
{
    void Attach(IObsersver obsersver);
    void Detach(IObsersver obsersver);
    void Notify();
}

// Classe Product que implementa o Subject - [Quem Gera a mensagem]
public class Product : ISubject
{
    public string Name { get;}
    private decimal _price;
    private readonly List<IObsersver> _obsersvers = new List<IObsersver>();

    public Product(string name, decimal price)
    {
        Name = name;
        _price = price;
    }
    public void SetPrice(decimal price)
    {
        _price = price;
        Notify();
    }
    public void Attach(IObsersver obsersver)
    {
        _obsersvers.Add(obsersver);
    }

    public void Detach(IObsersver obsersver)
    {
        _obsersvers.Remove(obsersver);
    }

    public void Notify()
    {
        foreach (var obsersver in _obsersvers)
        {
            obsersver.Updadte(Name, _price);
        }
    }
}

// Componente Price Alert que implementa o Observer [Quem Ouve a mensagem]
public class PriceAlert : IObsersver
{
    public void Updadte(string productName, decimal price)
    {
        Console.WriteLine($"PriceAlert: The price of {productName}: has changed to {price}");
    }
}

// Componente PriceDisplay que implementa o Observer [Quem Ouve a mensagem]
public class PriceDisplay : IObsersver
{
    public void Updadte(string productName, decimal price)
    {
        Console.WriteLine($"PriceDispaly: The price of {productName}: is now {price}");
    }
}