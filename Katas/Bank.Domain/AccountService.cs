namespace Bank.Domain;

public interface AccountService
{
    void Deposit(int amount);
    void Withdraw(int amount);
    void PrintStatement();
}