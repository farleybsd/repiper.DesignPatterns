namespace Design.Patterns.Ripiper.Facade.BAD;
/*
 * Complexidade Exposta
 * Forte Acoplamento
 *  Dificuldade de manutencao
 */
// Subsistema de Pagamento
public class PaymentProcessor
{
    public bool ProcessPayment(string paymentDetails)
    {
        Console.WriteLine($"Processing payment: {paymentDetails}");
        // Logica para Processar o Pagamento
        return true;  // Supondo  que o pagamento foi bem-sucedido
    }
}
// Subsistema de Estoque
public class Inventorysystem
{
    public bool CheckStock(string itemid)
    {
        Console.WriteLine($"Checking stock: {itemid}");
        // Logica para verificar estoque
        return true; // Supondo que o item esta em estoque
    }

    public void UpdateStoch(string itemid)
    {
        Console.WriteLine($"Updating stock: {itemid}");
        // Logica para atualizar o estoque
    }
}
// Subsistema de Notificacao
public class NotificationService
{
    public void SenfNotifications(string mensagem)
    {
        Console.WriteLine($"Sending notifications: {mensagem}");
        // Logica para enviar notifcacao
    }
}
// Cliente interagindo diretamente com os subsistemas
public class OrderService
{
    public void PlaceOrder(string itemid, string paymentDetails)
    {
        var inventorysystem = new Inventorysystem();
        var paymentProcessor = new PaymentProcessor();
        var notificationService = new NotificationService();
        if (inventorysystem.CheckStock(itemid))
        {
            if (paymentProcessor.ProcessPayment(paymentDetails))
            {
                inventorysystem.UpdateStoch(itemid);
                notificationService.SenfNotifications($"Order placed successfully for item {itemid}");
            }
        }
    }
}