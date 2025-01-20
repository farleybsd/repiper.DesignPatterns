namespace Designer.Patterns.Ripper.iterator.BAD;

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
// Classe Que Simula uma Lista de Produtos com a interacao Direta
public class ProductList
{
    private readonly List<Product> _products = new List<Product>();

    public void Add(Product product)
    {
        _products.Add(product);
    }
    public List<Product> GetProducts() => _products;    
}

// Classe que processa os produtos sem usar o padrao Iterator
public class ProductProcessor
{
    public void PrintProductList(ProductList productList)
    {
        var products = productList.GetProducts();
        
        // O iterator e para evitar isso
        for (int i = 0; i < products.Count; i++)
        {
            var product = products[i];
            Console.WriteLine($"Produto: {product.Name}, Preco: {product.Price}");
        }
    }
}