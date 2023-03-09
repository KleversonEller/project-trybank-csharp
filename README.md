# **Contexto do projeto**

Criando um sistema bancário com criação de novos usuários, saque, depósitos e transferências, esse projeto foi proposto para validar meus aprendizados em C# relacionados a minha 3ª semana de estudos.
<br/>
O projeto conta com a lógica do sistema bancário e testes unitários que valida essa lógica.
<br/>
(Obs: esse projeto não conta com um executável).

## **Stacks utilizadas no projeto**

Foi utilizado o .NET Core na versão 6.0
<br/>
A biblioteca de testes xUnit e a Fluent Assertions
<br/>

## **Como iniciar o projeto localmente**

Caso queira iniciar o projeto localmente devera ter instalado o .NET 6.0 e seguir os seguintes passos:
<br/>
Primeiro clone o projeto:
<br/>

```sh
git clone git@github.com:KleversonEller/project-trybank-csharp.git
```
<br/>

Em seguida entre na pasta do projeto e utilize o seguinte comando para instalar as dependências do projeto:
<br/>

```sh
cd project-trybank-csharp/src
dotnet restore
```
<br/>

Caso queira executar os testes basta utilizar:
<br/>

```sh
cd project-trybank-csharp/src
dotnet test
```