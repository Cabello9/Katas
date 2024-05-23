namespace Bank.Domain;

public class Account : AccountService
{
    public List<string> Statement { get; } = [];
    
    public void Deposit(int amount)
    {
        Statement.Add(amount.ToString());
    }

    public void Withdraw(int amount)
    {
        throw new NotImplementedException();
    }

    public void PrintStatement()
    {
        throw new NotImplementedException();
    }
}