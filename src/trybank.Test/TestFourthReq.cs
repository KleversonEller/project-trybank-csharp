using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestFourthReq
{
    [Theory(DisplayName = "Deve transefir um valor com uma conta logada")]
    [InlineData(0, 0)]
    public void TestTransferSucess(int balance, int value)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0)]
    public void TestTransferWithoutLogin(int value)
    {        
        throw new NotImplementedException();
    }

    [Theory(DisplayName = "Deve lançar uma exceção de usuário não logado")]
    [InlineData(0, 0)]
    public void TestTransferWithoutBalance(int balance, int value)
    {        
        throw new NotImplementedException();
    }
}
