namespace Design.Patterns.Ripiper.TemplateMethod.GOOD;

public class Order
{
    public double Amount { get; set; }
}
// Classe Abstrata que defone o template Method
public abstract class PaymentProcessor
{
    // Template Method que Define o Esqueleto do processo de pagamento
    public void ProcessPayment(Order order)
    {
        ValidarPaymentDetails();
        ProcessOrderPayment(order);
        SendConfirmation();
    }
    
    // Metodo abstrato para validacao de detahlher implemetado pela sublclass
    protected abstract void ValidarPaymentDetails();
    // Metodo abstrato para o processamento do pagamento implemetado pela sublclass
    protected abstract void ProcessOrderPayment(Order order);
    // Metodo concreto para o envio de confirmacao comum a todos metodos de pagamento
    protected virtual void SendConfirmation()
    {
        Console.WriteLine("Enviando Confirmacao de Pagamento");
    }
}

// Classe Concreta para Processamento de Pagamento por cartao de credito
public class CreditCardPaymentProcessor : PaymentProcessor
{
    protected override void ValidarPaymentDetails()
    {
        Console.WriteLine("Validando dados do cartao....");
    }

    protected override void ProcessOrderPayment(Order order)
    {
        Console.WriteLine($"Processamento de pagamento de {order.Amount:c} do cartao de credito....");
    }
}

// Classe Concreta para Processamento de Pagamento por PayPal
public class PayPalPaymentProcessor : PaymentProcessor
{
    protected override void ValidarPaymentDetails()
    {
        Console.WriteLine("Validando dados do PayPal....");
    }

    protected override void ProcessOrderPayment(Order order)
    {
        Console.WriteLine($"Processamento de pagamento de {order.Amount:c} via PayPal....");
    }
}