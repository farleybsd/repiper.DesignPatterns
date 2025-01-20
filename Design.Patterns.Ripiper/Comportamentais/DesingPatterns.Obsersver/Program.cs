
using DesingPatterns.Obsersver.GOOD;

var product = new Product("Laptop",1500.00m);
var display = new PriceDisplay();
var alert = new PriceAlert();

product.Attach(display);
product.Attach(alert);
product.SetPrice(1400.00m);