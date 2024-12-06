namespace Repiper.DesignPatterns.Grasp.InformationExpert.Bad;
public class Invoice
{
    public List<InvoiceItem> Items { get; set; }
    public double Discount { get; set; }

    public Invoice()
    {
        Items = new List<InvoiceItem>();
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
    /*
     *  Acoplamento Desnecessario - [ Calculo Total , Calculo Desconto]
     *  Baixa Coesao - [Deveria estar os Calculos na classe Invoice]
     *  Dificuldade de manutencao - [Se o calculo Mudar tanto a classe Invoice e InvoicePrinter devera ser modificada]
     *  Resumindo - [ Todos os Calculos deveriam ser da classe Invoice]
     */
    public void PrintInvoice(Invoice invoice)
    {
        double total = 0;

        foreach (var item in invoice.Items)
        {
            total += item.Price * item.Quantity;
        }

        double totalWithDiscount = total - (total * invoice.Discount);

        Console.WriteLine($"Invoice with discount: {totalWithDiscount} ");
    }
}