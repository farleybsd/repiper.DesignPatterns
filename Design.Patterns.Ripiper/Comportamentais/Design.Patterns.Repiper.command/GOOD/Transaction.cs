using Design.Patterns.Repiper.command.BAD;

namespace Design.Patterns.Repiper.command.GOOD;

// Interface Command que Define o Contrato para os comandos.
public interface ITransaction
{
    void Execute();
    void Undo();
}
// Classe concreta para operacao de depositos
public class DepositTransaction : ITransaction
{
    private readonly BankAccout _bankAccount;
    private readonly decimal _amount;

    public DepositTransaction(BankAccout bankAccount, decimal amount)
    {
        _bankAccount = bankAccount;
        _amount = amount;
    }

    public void Execute()
    {
        _bankAccount.Deposit(_amount);
    }

    public void Undo()
    {
        _bankAccount.Withdraw(_amount); // Desfazendo o deposito com um saque
    }
}

// Classe Concreta para Operacao de saque 
public class WithdrawTransaction : ITransaction
{
    private readonly BankAccout _accout;
    private readonly decimal _amount;

    public WithdrawTransaction(BankAccout accout, decimal amount)
    {
        _accout = accout;
        _amount = amount;
    }

    public void Execute()
    {
        _accout.Withdraw(_amount);
    }

    public void Undo()
    {
        _accout.Deposit(_amount);// Desfazendo o saque com um  deposito 
    }
}
// Clase que gerencia e enfileira as transcoes 
public class TransactionManager
{
    private readonly List<ITransaction> _transactionHistory = new List<ITransaction>();

    public void ExecuteTransaction(ITransaction transaction)
    {
        transaction.Execute();
        _transactionHistory.Add(transaction);
    }

    public void UndoTransaction(ITransaction transaction)
    {
        if (_transactionHistory.Count > 0)
        {
            var lastTransaction = _transactionHistory[^1];
            transaction.Undo();
            _transactionHistory.Remove(lastTransaction);
        }
    }
}