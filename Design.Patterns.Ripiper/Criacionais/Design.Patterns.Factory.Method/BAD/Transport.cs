namespace Design.Patterns.Factory.Method.BAD;

public class Transport
{
    public void Delivery(string type)
    {
        // Baixa Extensibilidade
        // Dificuldade de manutencao
        if (type =="Truck")
        {
            var truck = new Truck(); // Acoplamento
            truck.Delivery();
        }
        else if(type =="Ship")
        {
            var ship = new Ship(); // Acoplamento
            ship.Delivery();
        }
        else
        {
            throw new NotSupportedException("Transport type not supported");
        }
    }
}

public class Truck
{
    public void Delivery()
    {
        Console.WriteLine("Delivery Truck");
    }
}

public class Ship
{
    public void Delivery()
    {
        Console.WriteLine("Delivery Ship");
    }
}