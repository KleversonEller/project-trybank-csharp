using Xunit;
using FluentAssertions;
using trybank;
using System;

namespace trybank.Test;

public class TestSecondReq
{
    [Theory(DisplayName = "Deve logar em uma conta!")]
    [InlineData(35, 76543, 767896)]
    public void TestLoginSucess(int number, int agency, int pass)
    {        
        Trybank instance = new();

        instance.RegisterAccount(number, agency, pass);
        instance.Login(number, agency, pass);

        instance.Logged.Should().Be(true);
    }

    [Theory(DisplayName = "Deve retornar exceção ao tentar logar em conta já logada")]
    [InlineData(0, 0, 0)]
    public void TestLoginExceptionLogged(int number, int agency, int pass)
    {        
        Trybank instance = new()
        {
            Logged = true
        };

        Action result = () => instance.Login(number, agency, pass);

        result.Should().Throw<AccessViolationException>().WithMessage("Usuário já está logado");
    }

    [Theory(DisplayName = "Deve retornar exceção ao errar a senha")]
    [InlineData(0001, 123, 0000)]
    public void TestLoginExceptionWrongPass(int number, int agency, int pass)
    {        
        Trybank instance = new();

        instance.RegisterAccount(number, agency, pass);

        Action result = () => instance.Login(number, agency, pass+5);

        result.Should().Throw<ArgumentException>().WithMessage("Senha incorreta");
    }

    [Theory(DisplayName = "Deve retornar exceção ao digitar conta que não existe")]
    [InlineData(35, 76543, 767896)]
    public void TestLoginExceptionNotFounded(int number, int agency, int pass)
    {        
        Trybank instance = new();

        instance.RegisterAccount(number, agency, pass);

        Action result = () => instance.Login(16, 20, 0);

        result.Should().Throw<ArgumentException>().WithMessage("Agência + Conta não encontrada");
    }

    [Theory(DisplayName = "Deve sair de uma conta!")]
    [InlineData(0, 0, 0)]
    public void TestLogoutSucess(int number, int agency, int pass)
    {        
        Trybank instance = new()
        {
            Logged = true
        };

        instance.Logout();

        instance.Logged.Should().Be(false);
    }

    [Theory(DisplayName = "Deve retornar exceção ao sair quando não está logado")]
    [InlineData(0, 0, 0)]
    public void TestLogoutExceptionNotLogged(int number, int agency, int pass)
    {        
        Trybank instance = new();

        Action result = () => instance.Logout();

        result.Should().Throw<AccessViolationException>().WithMessage("Usuário não está logado");
    }

}
