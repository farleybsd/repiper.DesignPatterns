namespace Design.Patterns.Ripiper.TemplateMethod.BAD;

//Classe que representa o Pedido
public class Order
{
    public double Amount { get; set; }
}
// Classe  para processamento de pagamento por cartao de credito
public class CreditCardPaymentProcessor
{
    public void ProcessorPayment(Order order)
    {
        // Validacao do Cartao
        Console.WriteLine("Validando dados do Cartao....");
        
        // Processando Pagamento
        Console.WriteLine($"Processamento pagamento de {order.Amount:c} no cartao de credito....");
        
        // Envio de Confirmacao
        Console.WriteLine("Enviando cofirmacao de pagamento....");
    }
}

// Classe que representa o Pagamento por PayPal
public class PayPalPaymentProcessor
{
    public void ProcessorPayment(Order order)
    {
        // Validacao do Paypal
        Console.WriteLine("Validando dados do Paypal....");
        
        // Processando Pagamento
        Console.WriteLine($"Processamento pagamento de {order.Amount:c} no Paypal....");
        
        // Envio de Confirmacao
        Console.WriteLine("Enviando cofirmacao de pagamento....");
    }
}