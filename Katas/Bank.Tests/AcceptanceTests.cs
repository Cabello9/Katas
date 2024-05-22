using Bank.Domain;
using FluentAssertions;

namespace Bank.Tests;

public class AcceptanceTests
{
    [Test]
    public void PrintBankStatement()
    {
        var sut = new Account();
        sut.deposit(1000);
        sut.deposit(2000);
        sut.withdraw(500);
        sut.printStatement();

        sut.Statement.Should().HaveCount(3);
        sut.Statement[0].Should().Be("14/01/2012 || -500 || 2500");
        sut.Statement[1].Should().Be("13/01/2012 || 2000 || 3000");
        sut.Statement[2].Should().Be("10/01/2012 || 1000 || 1000");
    }
}