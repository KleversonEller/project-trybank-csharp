namespace trybank;

public class Trybank
{
    public bool Logged;
    public int loggedUser;
    
    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;
    public Trybank()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    public void RegisterAccount(int number, int agency, int pass)
    {

        try
        {
            int[] userInfos = new int[3] {number, agency, pass};

            for(int conta = 0; conta < Bank.GetLength(0); conta++)
            {
                bool haveNumber = false;
                bool haveAgency = false;
                for(int user = 0; user < Bank.GetLength(1); user++)
                {
                    if(Bank[conta, user] == number) haveNumber = true;
                    if(Bank[conta, user] == agency) haveAgency = true;

                    if(haveAgency && haveNumber) throw new ArgumentException("A conta já está sendo usada!");;
                };
            };

            for (int info = 0; info < userInfos.Length; info++)
            {
                Bank[registeredAccounts, info] = userInfos[info];
            }
            registeredAccounts += 1;

        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
    }

    public void Login(int number, int agency, int pass)
    {
        try
        {
            if(Logged) throw new AccessViolationException("Usuário já está logado");

            for(int conta = 0; conta < Bank.GetLength(0); conta++)
            {
                bool validNumber = false;
                bool validAgency = false;
                bool validPass = false;

                for(int user = 0; user < 3; user++)
                {
                    if(Bank[conta, user] == number) validNumber = true;
                    if(Bank[conta, user] == agency) validAgency = true;
                    if(Bank[conta, user] == pass) validPass = true;
                };

                if(!validNumber && !validAgency) throw new ArgumentException("Agência + Conta não encontrada");
                if(!validPass) throw new ArgumentException("Senha incorreta");
                if(validAgency && validNumber && validPass)
                {
                    Logged = true;
                    loggedUser = conta;
                    break;
                };
            };
        }
        catch (AccessViolationException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
        catch (ArgumentException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
    }

    public void Logout()
    {
        try
        {
            if(!Logged) throw new AccessViolationException("Usuário não está logado");
            else
            {
                Logged = false;
                loggedUser = -99;
            }
        }
        catch (AccessViolationException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
    }

    public int CheckBalance()
    {
        try
        {
            if(!Logged) throw new AccessViolationException("Usuário não está logado");
            else return Bank[loggedUser, 3];
        }
        catch (AccessViolationException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
    }

    public void Transfer(int destinationNumber, int value)
    {
        Withdraw(value);
        Bank[destinationNumber, 3] = value;
    }

    public void Deposit(int value)
    {
        try
        {
            if(!Logged) throw new AccessViolationException("Usuário não está logado");
            else Bank[loggedUser, 3] = value;
        }
        catch (AccessViolationException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
    }

    public void Withdraw(int value)
    {
        try
        {
            if(!Logged) throw new AccessViolationException("Usuário não está logado");
            if(Bank[loggedUser, 3] < value) throw new InvalidOperationException("Saldo insuficiente");
            else Bank[loggedUser, 3] -= value;
        }
        catch (AccessViolationException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
        catch (InvalidOperationException error)
        {
            Console.WriteLine(error.Message);
            throw;
        }
    }
}
