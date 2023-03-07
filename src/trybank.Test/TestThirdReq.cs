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
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestCheckBalanceWithoutLogin(int balance)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve depositar um saldo em uma conta logada")]
    [InlineData(0)]
    public void TestDepositSucess(int value)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestDepositWithoutLogin(int value)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve sacar um valor em uma conta logada")]
    [InlineData(0, 0)]
    public void TestWithdrawSucess(int balance, int value)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestWithdrawWithoutLogin(int value)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0, 0)]
    public void TestWithdrawWithoutBalance(int balance, int value)
    {        
        throw new NotImplementedException();
    }
}