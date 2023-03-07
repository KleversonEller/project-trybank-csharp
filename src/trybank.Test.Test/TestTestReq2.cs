using Xunit;
using FluentAssertions;
using System;


namespace trybank.Test.Test;

public class TestTestReq2
{
    [Trait("Category", "2 - A pessoa usuária deve conseguir fazer Login e Logout")]
    [Theory(DisplayName = "TestLoginSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestLoginSucess(int number, int agency, int pass)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestLoginSucess(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - A pessoa usuária deve conseguir fazer Login e Logout")]
    [Theory(DisplayName = "TestLoginExceptionLogged deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestLoginExceptionLogged(int number, int agency, int pass)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestLoginExceptionLogged(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - A pessoa usuária deve conseguir fazer Login e Logout")]
    [Theory(DisplayName = "TestLoginExceptionWrongPass deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestLoginExceptionWrongPass(int number, int agency, int pass)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestLoginExceptionWrongPass(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - A pessoa usuária deve conseguir fazer Login e Logout")]
    [Theory(DisplayName = "TestLoginExceptionNotFounded deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestLoginExceptionNotFounded(int number, int agency, int pass)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestLoginExceptionNotFounded(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - A pessoa usuária deve conseguir fazer Login e Logout")]
    [Theory(DisplayName = "TestLogoutSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestLogoutSucess(int number, int agency, int pass)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestLogoutSucess(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "2 - A pessoa usuária deve conseguir fazer Login e Logout")]
    [Theory(DisplayName = "TestLogoutExceptionNotLogged deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestLogoutExceptionNotLogged(int number, int agency, int pass)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestLogoutExceptionNotLogged(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}