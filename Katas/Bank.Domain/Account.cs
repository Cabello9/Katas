namespace Bank.Domain;

public class Account : AccountService
{
    public List<string> Statement { get; }
    
    public void deposit(int amount)
    {
        throw new NotImplementedException();
    }

    public void withdraw(int amount)
    {
        throw new NotImplementedException();
    }

    public void printStatement()
    {
        throw new NotImplementedException();
    }
}