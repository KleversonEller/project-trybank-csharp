using Xunit;
using System;
using FluentAssertions;

namespace trybank.Test.Test;

[Collection("Sequential")]
public class TestTestReq1
{
    [Trait("Category", "1 - O programa deve cadastrar novas contas")]
    [Theory(DisplayName = "TestRegisterAccountSucess deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestRegisterAccountSucess(int number, int agency, int pass)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestRegisterAccountSucess(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

    [Trait("Category", "1 - O programa deve cadastrar novas contas")]
    [Theory(DisplayName = "TestRegisterAccountException deve ser executado com sucesso com entradas corretas")]
    [InlineData(1234, 123, 1010)]
    [InlineData(1111, 123, 0123)]
    [InlineData(0001, 123, 0000)]
    [InlineData(9999999, 123, 9999)]
    [InlineData(1, 2, 3)]
    public void TestSucessTestRegisterAccountException(int number, int agency, int pass)
    {
        TestFirstReq instance = new();
        Action act = () => instance.TestRegisterAccountException(number, agency, pass);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}