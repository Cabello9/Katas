using Bank.Domain;
using FluentAssertions;
using FluentAssertions.Extensions;
using NSubstitute;

namespace Bank.Tests;

public class AcceptanceTests
{
    [Test]
    public void NewAccount_HasEmptyStatement()
    {
        new Account(Substitute.For<TimeService>()).Statement.Should().BeEmpty();
    }
    
    [Test]
    public void Deposit()
    {
        var timeServiceMock = Substitute.For<TimeService>();
        timeServiceMock.Now.ReturnsForAnyArgs(23.May(2024));
        var sut = new Account(timeServiceMock);
        
        sut.Deposit(500);
        
        sut.Statement.Should().HaveCount(1);
        sut.Statement[0].ToString().Should().Be("23/05/2024 || 500");
    }
    
    [Test, Ignore("")]
    public void PrintBankStatement()
    {
        var sut = new Account(Substitute.For<TimeService>());
        sut.Deposit(1000);
        sut.Deposit(2000);
        sut.Withdraw(500);
        sut.PrintStatement();

        sut.Statement.Should().HaveCount(3);
        sut.Statement[0].Should().Be("14/01/2012 || -500 || 2500");
        sut.Statement[1].Should().Be("13/01/2012 || 2000 || 3000");
        sut.Statement[2].Should().Be("10/01/2012 || 1000 || 1000");
    }
}