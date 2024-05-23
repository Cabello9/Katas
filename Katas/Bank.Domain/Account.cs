namespace Bank.Domain;

public struct Transaction
{
    public int Amount { get; init; }
    public DateTime When { get; init; }
    
    public override string ToString()
    {
        return $"{When:dd/MM/yyyy} || {Amount.ToString()}";
    }
}

public interface TimeService
{
    public DateTime Now { get; }
}

public class Account(TimeService timeService) : AccountService
{
    readonly TimeService timeService = timeService;
    
    public List<Transaction> Statement { get; } = [];

    public void Deposit(int amount)
    {
        Statement.Add(new Transaction
        {
            Amount = amount,
            When = timeService.Now
        });
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