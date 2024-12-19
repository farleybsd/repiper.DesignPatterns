namespace Design.Patterns.Ripiper.Facade.GOOD;
/*
 * Simplicidade
 * Desacoplamento
 * Melhor usabilidade
 */
public class PaymentPocessorGood
{
// Subsistema de Pagamento
    public class PaymentProcessor
    {
        public bool ProcessPayment(string paymentDetails)
        {
            Console.WriteLine($"Processing payment: {paymentDetails}");
            // Logica para Processar o Pagamento
            return true; // Supondo  que o pagamento foi bem-sucedido
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
}

// Facade para Simplificar a interface do cliente 
public class OrderFacade
{
    private readonly PaymentPocessorGood.PaymentProcessor _payment;
    private readonly PaymentPocessorGood.Inventorysystem _inventorysystem;
    private readonly PaymentPocessorGood.NotificationService _notificationService;

    public OrderFacade()
    {
        _payment = new PaymentPocessorGood.PaymentProcessor();
        _inventorysystem = new PaymentPocessorGood.Inventorysystem();
        _notificationService = new PaymentPocessorGood.NotificationService();
    }
    public void PlaceOrder(string itemid, string paymentDetails)
    {
        if (_inventorysystem.CheckStock(itemid))
        {
            if (_payment.ProcessPayment(paymentDetails))
            {
                _inventorysystem.UpdateStoch(itemid);
                _notificationService.SenfNotifications($"Order placed successfully for item {itemid}");
            }
        }
    }
}