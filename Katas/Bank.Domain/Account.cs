namespace Bank.Domain;

public class Account : AccountService
{
    DateTime date { get; } = DateTime.Now.Date;
    
    public List<string> Statement { get; } = [];
    
    public void Deposit(int amount)
    {
        Statement.Add($"{date.ToShortDateString()} || {amount.ToString()}");
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