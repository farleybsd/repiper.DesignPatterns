namespace Repiper.DesignPatterns.Grasp.Pure.Fabrication.BAD;

public class Invoice
{
    public string InvoiceNumber { get; set; }
    public double Amount { get; set; }

    public Invoice(string invoiceNumber, double amount)
    {
        InvoiceNumber = invoiceNumber;
        Amount = amount;
    }

    public void Save()
    {
        // Simulacao Salvando no Banco de Dados
        Console.WriteLine("Invoice saved");
    }
}