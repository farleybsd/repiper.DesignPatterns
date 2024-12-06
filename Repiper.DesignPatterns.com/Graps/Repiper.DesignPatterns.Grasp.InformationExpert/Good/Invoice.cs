namespace Repiper.DesignPatterns.Grasp.InformationExpert.Good;

public class Invoice
{
    /*
     * Alta Coesao - [Responsavel por gerenciar os items e os calculos]
     * Baixo Acoplamento - [Calculos estao na classe Invoice deixando tudo caldulado para InvoicePrinter]
     * Facilidade de Manutencao - [Cada classe com sua responsavilidade aparecendo alteracao seja feita na  classe Invoice deixando a InvoicePrinter intocavel]
     */
    public List<InvoiceItem> Items { get; set; }
    public double Discount { get; set; }

    public Invoice()
    {
        Items = new List<InvoiceItem>();
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (var item in Items)
        {
            total += item.Price * item.Quantity;
        }

        return total;
    }

    public double CalculateDiscount()
    {
        double total = CalculateTotal();
        return total - (total * Discount);
    }
}

public class InvoiceItem
{
    public string Description { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

public class InvoicePrinter
{
    public void PrintInvoice(Invoice invoice)
    {
        double totalwithDiscount = invoice.CalculateTotal();
        Console.WriteLine($"Invoice with discount: {totalwithDiscount} ");
    }
}