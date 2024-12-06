namespace Repiper.DesignPatterns.Grasp.Polymorphism.BAD;

public class PaymentProcessor
{
    public void ProcessorPayment(string paymentType)
    {
        if (paymentType == "CreditCard")
        {
            ProcessCreditCardPayment();
        }
        else if (paymentType == "PayPal")
        {
            ProcessPayPalPayment();
        }
        else if (paymentType == "BankTransfer")
        {
            ProcessBankTransferPayment();
        }
        else
        {
            throw new NotSupportedException("Payment type not supported");
        }
    }

    private void ProcessBankTransferPayment()
    {
        Console.WriteLine("Bank Transfer Payment");
    }

    private void ProcessPayPalPayment()
    {
        Console.WriteLine("PayPal payment");
    }

    private void ProcessCreditCardPayment()
    {
        Console.WriteLine("Credit card payment");
    }
}