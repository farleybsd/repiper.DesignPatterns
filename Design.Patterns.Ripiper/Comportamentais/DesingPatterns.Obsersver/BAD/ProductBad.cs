using System.Collections.Specialized;

namespace DesingPatterns.Obsersver.BAD;
/*
 *  Forte Acoplamento
 *  Dificuldade para gerar novos comportamentos
 *  Codigo Rigido e pouco Flexivel
 */
// Classe Produto que mantem o preco de um produto
public class ProductBad
{
    public string Name { get;}
    private decimal _price;
    
    // Depedencias Diretas
    private readonly PriceDisplay _priceDisplay;
    private readonly PriceAlert _priceAlert;

    public ProductBad(string name, decimal price, PriceDisplay priceDisplay, PriceAlert priceAlert)
    {
        Name = name;
        _price = price;
        _priceDisplay = priceDisplay;
        _priceAlert = priceAlert;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
        NotifyPriceChange();
    }

    private void NotifyPriceChange()
    {
        // Notificacao Direta aos Depedentes
        _priceDisplay.ShowUpdatedPrice(Name,_price);
        _priceAlert.SendPriceAlert(Name,_price);
    }
}

// Componente que exibe o preco do produto
public class PriceDisplay
{
    public void ShowUpdatedPrice(string productName, decimal productPrice)
    {
        Console.WriteLine($"PriceDispaly: The price of {productName}: is now {productPrice}");
    }
}
// Componente que alerta sobre a mudanca de preco
public class PriceAlert
{
    public void SendPriceAlert(string productName, decimal productPrice)
    {
        Console.WriteLine($"PriceAlert: The price of {productName}: has changed to {productPrice}");
    }
}