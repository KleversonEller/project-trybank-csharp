using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestFourthReq
{
    [Theory(DisplayName = "Deve transefir um valor com uma conta logada")]
    [InlineData(100, 40)]
    public void TestTransferSucess(int balance, int value)
    {        
        Trybank instance = new();

        instance.RegisterAccount(25, 65743, 951604);
        instance.RegisterAccount(30, 65740, 951604);
        instance.Login(25, 65743, 951604);
        instance.Deposit(balance);
        instance.Transfer(1, value);

        instance.CheckBalance().Should().Be(balance - value);
        instance.Bank[1, 3].Should().Be(value);
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestTransferWithoutLogin(int value)
    {        
        Trybank instance = new();

        Action result = () => instance.Transfer(1, value);

        result.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(50, 100)]
    public void TestTransferWithoutBalance(int balance, int value)
    {        
        Trybank instance = new();

        instance.RegisterAccount(25, 65743, 951604);
        instance.Login(25, 65743, 951604);
        instance.Deposit(balance);
        
        Action result = () => instance.Transfer(1, value);

        result.Should().Throw<InvalidOperationException>().WithMessage("Saldo insuficiente");
    }
}
