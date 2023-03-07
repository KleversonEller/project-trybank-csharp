using Xunit;
using FluentAssertions;
using System;

namespace trybank.Test.Test;

public class TestTestReq4
{
    [Trait("Category", "4 - O programa deve transferir dinheiro entre contas")]
    [Theory(DisplayName = "TestTransferSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(9000, 1010)]
    [InlineData(9000, 9000)]
    [InlineData(200, 123)]
    [InlineData(2, 1)]
    [InlineData(0, 0)]
    public void TestSucessTestTransferSucess(int balance, int value)
    {
        TestFourthReq instance = new();
        Action act = () => instance.TestTransferSucess(balance, value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "4 - O programa deve transferir dinheiro entre contas")]
    [Theory(DisplayName = "TestTransferWithoutLogin deve ser executado com sucesso com entradas corretas")]
    [InlineData(1010)]
    [InlineData(300)]
    [InlineData(123)]
    [InlineData(1)]
    [InlineData(0)]
    public void TestSucessTestTransferWithoutLogin(int value)
    {
        TestFourthReq instance = new();
        Action act = () => instance.TestTransferWithoutLogin(value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "4 - O programa deve transferir dinheiro entre contas")]
    [Theory(DisplayName = "TestTransferWithoutBalance deve ser executado com sucesso com entradas corretas")]
    [InlineData(1000, 1010)]
    [InlineData(100, 300)]
    [InlineData(122, 123)]
    [InlineData(0, 1)]
    [InlineData(1, 2)]
    public void TestSucessTestTransferWithoutBalance(int balance, int value)
    {
        TestFourthReq instance = new();
        Action act = () => instance.TestTransferWithoutBalance(balance, value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}
