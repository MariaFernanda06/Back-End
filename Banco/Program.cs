using Banco;

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("$ $ $ $ $ $ $ $ $ $");
        Console.WriteLine("Bem-vindo ao $$Bank");
        Console.WriteLine("$ $ $ $ $ $ $ $ $ $");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";
        Console.WriteLine("Digite seu nome:");
        ContaCorrente Conta = new ContaCorrente(Console.ReadLine());
        Console.WriteLine("$ $ $ $ $ $ $ $ $ $");
        Conta.BemVindo();

        do
        {
            Console.WriteLine("--------- MENU ---------");
            Console.WriteLine("1 - Para consultar saldo");
            Console.WriteLine("2 - Para depositar");
            Console.WriteLine("3 - Para sacar");
            Console.WriteLine("0 - Para sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !");
                    System.Threading.Thread.Sleep(1000); //Espera de 1s
                    break;
                case "1":
                    Conta.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite quanto você deseja depositar");
                    double valor = double.Parse(Console.ReadLine());
                    Conta.Depositar(valor);
                    break;
                case "3":
                    Console.WriteLine("Digite quanto você deseja sacar");
                    double Valor = double.Parse(Console.ReadLine());
                    Conta.Sacar(Valor);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (opcao != "0");
    }
}

