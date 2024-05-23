namespace Bank.Domain;

public class Account
{
    List<Transaction> Movements { get; } = [];
    
    public int CurrentBalance()
    {
        throw new NotImplementedException();
    }

    public List<string> Statements()
        => Movements.Select(m => m.ToString()).ToList();
    
    public void Register(Transaction transaction)
        => Movements.Add(transaction);
}