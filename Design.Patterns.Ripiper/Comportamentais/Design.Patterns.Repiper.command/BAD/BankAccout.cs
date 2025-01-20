namespace Design.Patterns.Repiper.command.BAD;

// Classe que representa uma conta bancaria
public class BankAccout
{
    public string AccountHolder { get; }
    public decimal Balance { get; private set; }
    public BankAccout(string accountHolder, decimal balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} realizado. Saldo Atual: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"DSaque {amount} realizado. Saldo Atual: {Balance}");
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente para realizar o saque");
        }
    }
    
}
// Sistema que execulta diretamente as operacoes de deposito e saque
public class BankSystem
{
    private readonly BankAccout _bankAccout;

    public BankSystem(BankAccout bankAccout)
    {
        _bankAccout = bankAccout;
    }

    public void PerformaDeposit(decimal amount)
    {
        _bankAccout.Deposit(amount);
    }

    public void PerformaWithdrawal(decimal amount)
    {
        _bankAccout.Withdraw(amount);
    }
}