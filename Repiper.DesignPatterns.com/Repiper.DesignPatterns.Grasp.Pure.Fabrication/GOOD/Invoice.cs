namespace Repiper.DesignPatterns.Grasp.Pure.Fabrication.GOOD;

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

// Classe Fabricada (Pure Fabrication) para persistencia de dados
public class InvoiceRepository
{
    public void Save(Invoice invoice)
    {
        // Simulacao Salvando no Banco de Dados
        Console.WriteLine($"Invoice saved-{invoice.InvoiceNumber} with amount {invoice.Amount}");
    }
}