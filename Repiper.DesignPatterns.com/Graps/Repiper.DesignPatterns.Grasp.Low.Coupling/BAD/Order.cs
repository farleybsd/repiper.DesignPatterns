namespace Repiper.DesignPatterns.Grasp.Low.Coupling.BAD;

public class Order
{
    public string OrderId { get; set; }
    public string CustomerEmail { get; set; }

    public Order(string orderId, string customerEmail)
    {
        OrderId = orderId;
        CustomerEmail = customerEmail;
    }
}

public class EmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Sending email to: {to} with subject: {subject} with body: {body}");
    }
}

public class OrderProcessor
{
    private EmailService _emailService;

    public OrderProcessor()
    {
        _emailService = new EmailService(); // Forca o Acoplamento
    }

    public void ProcessOrder(Order order)
    {
        _emailService.SendEmail(order.CustomerEmail, "Order Confirmation", "Your order has been proceses");
    }
}