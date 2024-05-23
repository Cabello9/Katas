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
        new AccountServiceImpl(new(), Substitute.For<TimeService>()).Statement.Should().BeEmpty();
    }
    
    [Test]
    public void Deposit()
    {
        var timeServiceMock = Substitute.For<TimeService>();
        timeServiceMock.Now.ReturnsForAnyArgs(23.May(2024));
        var sut = new AccountServiceImpl(new(), timeServiceMock);
        
        sut.Deposit(500);
        
        sut.Statement.Should().HaveCount(1);
        sut.Statement[0].Should().Be("23/05/2024 || 500 || 500");
    }
    
    [Test]
    public void DepositTwice()
    {
        var timeServiceMock = Substitute.For<TimeService>();
        timeServiceMock.Now.ReturnsForAnyArgs(23.May(2024), 25.May(2024));
        var sut = new AccountServiceImpl(new(), timeServiceMock);
        
        sut.Deposit(500);
        sut.Deposit(300);
        
        sut.Statement.Should().HaveCount(2);
        sut.Statement[0].Should().Be("25/05/2024 || 300 || 800");
        sut.Statement[1].Should().Be("23/05/2024 || 500 || 500");
    }
    
    [Test]
    public void PrintBankStatement()
    {
        var timeService = Substitute.For<TimeService>();
        timeService.Now.ReturnsForAnyArgs(10.January(2012), 13.January(2012), 14.January(2012));
        var sut = new AccountServiceImpl(new(), timeService);
        sut.Deposit(1000);
        sut.Deposit(2000);
        sut.Withdraw(500);

        sut.Statement.Should().HaveCount(3);
        sut.Statement[0].Should().Be("14/01/2012 || -500 || 2500");
        sut.Statement[1].Should().Be("13/01/2012 || 2000 || 3000");
        sut.Statement[2].Should().Be("10/01/2012 || 1000 || 1000");
    }
}