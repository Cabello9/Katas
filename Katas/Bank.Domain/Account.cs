namespace Bank.Domain;

public class Account
{
    List<Transaction> Movements { get; } = [];

    public IEnumerable<string> Statements()
    {
        var balance = 0;
        foreach(var transaction in Movements)
        {
            balance += transaction.Amount;
            yield return transaction+$" || {balance}";
        }
    }

    public void Register(Transaction transaction)
        => Movements.Add(transaction);
}