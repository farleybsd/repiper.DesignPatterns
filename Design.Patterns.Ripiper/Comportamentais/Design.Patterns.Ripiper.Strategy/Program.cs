using Design.Patterns.Ripiper.Strategy.GOOD;

var order = new Order(){Weight = 10,Destination = "Internacional"};
order.ShippingStrategy = new InterNationallShippingStrategy();
var cost = order.CalculateShippingCost();
Console.WriteLine($"O Custo do Frete: {cost:C}");