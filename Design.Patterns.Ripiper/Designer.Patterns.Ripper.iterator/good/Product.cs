using Designer.Patterns.Ripper.iterator.BAD;

namespace Designer.Patterns.Ripper.iterator.good;

//Classe Que Representa Um Produto
public class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
}

// Interface Iterator que Define o Contrato para os iteradores
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

// Interface para Definir a Colecao que Cria o Iterator
public interface IProductCollection
{
    IIterator<Product> CreateIterator();
}
//Classe Concreta que implementa a Colecao de Produtos
public class ProductCollection : IProductCollection
{
    private readonly List<Product> _products = new List<Product>();
    
    public void Add(Product product) => _products.Add(product);

    public IIterator<Product> CreateIterator()
    {
        return new ProductITerator(_products);
    }
}
// Classe Concreta que implementa o Iterator para Colecao de Produtod
public class ProductITerator : IIterator<Product>
{
    private readonly List<Product> _products;
    private int _currentIndex = 0;

    public ProductITerator(List<Product> products)
    {
        _products = products;
    }

    public bool HasNext()
    {
        return _currentIndex < _products.Count;
    }

    public Product Next()
    {
        return _products[_currentIndex++];
    }
}
//Classe que processa os produtos usando o padrao iterator

public class PrductProcessor
{
    public void PrintProductList(IProductCollection productCollection)
    {
        var iterator = productCollection.CreateIterator();
        //Evitar fazer for ou foreach
        while (iterator.HasNext())
        {   
            var product = iterator.Next();
            Console.WriteLine($"Produto: {product.Name} preco: {product.Price}");
        }
    } 
}