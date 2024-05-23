namespace Bank.Domain;

public class Account : AccountService
{
    public List<string> Statement { get; }
    
    public void Deposit(int amount)
    {
        throw new NotImplementedException();
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