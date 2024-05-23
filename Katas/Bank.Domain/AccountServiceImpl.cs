namespace Bank.Domain;

public interface TimeService
{
    public DateTime Now { get; }
}

public class AccountServiceImpl : AccountService
{
    readonly Account account;
    readonly TimeService timeService;

    public AccountServiceImpl(Account account, TimeService timeService)
    {
        this.account = account;
        this.timeService = timeService;
    }

    public List<string> Statement => account.Statements().Reverse().ToList();

    public void Deposit(int amount)
    {
        account.Register(new Transaction
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