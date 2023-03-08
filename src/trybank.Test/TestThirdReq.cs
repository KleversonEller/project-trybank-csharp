using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestThirdReq
{
    [Theory(DisplayName = "Deve devolver o saldo em uma conta logada")]
    [InlineData(0)]
    public void TestCheckBalanceSucess(int balance)
    {        
        Trybank instance = new();

        instance.RegisterAccount(25, 65743, 951604);
        instance.Login(25, 65743, 951604);
        instance.Deposit(balance);

        instance.CheckBalance().Should().Be(balance);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestCheckBalanceWithoutLogin(int balance)
    {        
        Trybank instance = new();

        Action result = () => instance.CheckBalance();

        result.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

    [Theory(DisplayName = "Deve depositar um saldo em uma conta logada")]
    [InlineData(100)]
    public void TestDepositSucess(int value)
    {        
        Trybank instance = new();

        instance.RegisterAccount(25, 65743, 951604);
        instance.Login(25, 65743, 951604);
        instance.Deposit(value);

        instance.CheckBalance().Should().Be(value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestDepositWithoutLogin(int value)
    {        
        Trybank instance = new();

        Action result = () => instance.Deposit(value);

        result.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

    [Theory(DisplayName = "Deve sacar um valor em uma conta logada")]
    [InlineData(100, 40)]
    public void TestWithdrawSucess(int balance, int value)
    {        
        Trybank instance = new();

        instance.RegisterAccount(25, 65743, 951604);
        instance.Login(25, 65743, 951604);
        instance.Deposit(balance);
        instance.Withdraw(value);

        instance.CheckBalance().Should().Be(balance - value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestWithdrawWithoutLogin(int value)
    {        
        Trybank instance = new();

        Action result = () => instance.Withdraw(value);

        result.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(50, 100)]
    public void TestWithdrawWithoutBalance(int balance, int value)
    {        
        Trybank instance = new();

        instance.RegisterAccount(25, 65743, 951604);
        instance.Login(25, 65743, 951604);
        instance.Deposit(balance);
        
        Action result = () => instance.Withdraw(value);

        result.Should().Throw<InvalidOperationException>().WithMessage("Saldo insuficiente");
    }
}