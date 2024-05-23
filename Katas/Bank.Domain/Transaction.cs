namespace Bank.Domain;

public readonly struct Transaction
{
    public int Amount { get; init; }
    public DateTime When { get; init; }
    
    public override string ToString()
    {
        return $"{When:dd/MM/yyyy} || {Amount.ToString()}";
    }
}