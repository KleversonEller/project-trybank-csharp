using Xunit;
using FluentAssertions;
using System;

namespace trybank.Test.Test;

public class TestTestReq3
{
    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestCheckBalanceSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(1010)]
    [InlineData(300)]
    [InlineData(123)]
    [InlineData(1)]
    [InlineData(0)]
    public void TestSucessTestCheckBalanceSucess(int balance)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestCheckBalanceSucess(balance);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestCheckBalanceWithoutLogin deve ser executado com sucesso com entradas corretas")]
    [InlineData(1010)]
    [InlineData(300)]
    [InlineData(123)]
    [InlineData(1)]
    [InlineData(0)]
    public void TestSucessTestCheckBalanceWithoutLogin(int balance)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestCheckBalanceWithoutLogin(balance);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestDepositSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(1010)]
    [InlineData(300)]
    [InlineData(123)]
    [InlineData(1)]
    [InlineData(0)]
    public void TestSucessTestDepositSucess(int value)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestDepositSucess(value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestDepositWithoutLogin deve ser executado com sucesso com entradas corretas")]
    [InlineData(1010)]
    [InlineData(300)]
    [InlineData(123)]
    [InlineData(1)]
    [InlineData(0)]
    public void TestSucessTestDepositWithoutLogin(int value)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestDepositWithoutLogin(value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestWithdrawSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(9000, 1010)]
    [InlineData(9000, 9000)]
    [InlineData(200, 123)]
    [InlineData(2, 1)]
    [InlineData(0, 0)]
    public void TestSucessTestWithdrawSucess(int balance, int value)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestWithdrawSucess(balance, value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestWithdrawWithoutLogin deve ser executado com sucesso com entradas corretas")]
    [InlineData(1010)]
    [InlineData(300)]
    [InlineData(123)]
    [InlineData(1)]
    [InlineData(0)]
    public void TestSucessTestWithdrawWithoutLogin(int value)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestWithdrawWithoutLogin(value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "3 - O programa deve permitir checar o saldo, depositar e sacar dinheiro")]
    [Theory(DisplayName = "TestWithdrawWithoutBalance deve ser executado com sucesso com entradas corretas")]
    [InlineData(1000, 1010)]
    [InlineData(100, 300)]
    [InlineData(122, 123)]
    [InlineData(0, 1)]
    [InlineData(1, 2)]
    public void TestSucessTestWithdrawWithoutBalance(int balance, int value)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestWithdrawWithoutBalance(balance, value);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}