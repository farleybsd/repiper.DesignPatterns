namespace Repiper.DesignPatterns.Grasp.Creator.GOOD;

public class Invoice
{
    public string InvoiceNumber { get; set; }
    public double Amount { get; set; }

    public Invoice(string invoiceNumber, double amount)
    {
        InvoiceNumber = invoiceNumber;
        Amount = amount;
    }
}

public class Order
{
    public string OrderId { get; set; }
    public double OrderAmount { get; set; }

    public Order(string orderId, double orderAmount)
    {
        OrderId = orderId;
        OrderAmount = orderAmount;
    }
    
    //Criando a fatura dentro de Order que tem as informacoes necessarias
    public Invoice CreateInvoice()
    {
        return new Invoice($"INV-{OrderId}", OrderAmount);  
    }
    
}
public class PaymentProcessor
{
    public void ProcessPayment(Invoice invoice)
    {
        Console.WriteLine($"Processing invoice number: {invoice.InvoiceNumber} with payment amount: {invoice.Amount}");
    }
}