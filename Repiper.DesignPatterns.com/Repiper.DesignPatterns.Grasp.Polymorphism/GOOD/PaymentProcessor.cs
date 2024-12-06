namespace Repiper.DesignPatterns.Grasp.Polymorphism.GOOD;

// Interface Comun para todos os tipos de pagamento
public interface IPayment
{
    void ProcessPayment();
}

// Implementacao especifica para pagamentos com cartao de credito
public class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Credit card payment");
    }
}

// Implementacao especifica para pagamento Paypal
public class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Paypal payment");
    }
}

// Implementacao especifica para pagamento com transferencia Bancaria
public class BankTransferPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Bank transfer payment");
    }
}

// Classe que Processa o Pagamento
public class PaymentProcessor
{
    public void ProcessPayment(IPayment payment)
    {
        payment.ProcessPayment(); // Aqui esta o polimofirmos em Acao
    }
}