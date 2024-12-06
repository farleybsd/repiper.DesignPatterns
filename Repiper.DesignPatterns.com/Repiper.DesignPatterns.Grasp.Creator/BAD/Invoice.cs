namespace Repiper.DesignPatterns.Grasp.Creator.BAD;

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

public class PaymentProcessor
{
    public void ProcessPayment(string invoiceNumber, double amount)
    {
        //Criacao de uma nova fatura diretamente dentro da classe PaymentProcessor
        var invoice = new Invoice(invoiceNumber, amount);
        Console.WriteLine($"Processing invoice number: {invoice.InvoiceNumber} with payment amount: {amount}");
    }
}