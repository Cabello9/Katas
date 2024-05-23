namespace Bank.Domain;

public struct Transaction
{
    public int Amount { get; init; }
    public DateTime When { get; init; }
    
    public override string ToString()
    {
        return $"{When.ToShortDateString()} || {Amount.ToString()}";
    }
}

public class Account : AccountService
{
    DateTime date { get; } = DateTime.Now.Date;
    
    public List<Transaction> Statement { get; } = [];
    
    public void Deposit(int amount)
    {
        Statement.Add(new Transaction
        {
            Amount = amount,
            When = date
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