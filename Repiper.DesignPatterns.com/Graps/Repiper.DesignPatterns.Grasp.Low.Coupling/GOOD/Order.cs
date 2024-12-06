namespace Repiper.DesignPatterns.Grasp.Low.Coupling.GOOD;
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

public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
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
    private IEmailService _emailService;

    public OrderProcessor(IEmailService emailService)
    {
        _emailService = emailService; // Baixo  Acoplamento
    }

    public void ProcessOrder(Order order)
    {
        _emailService.SendEmail(order.CustomerEmail, "Order Confirmation", "Your order has been proceses");
    }
}