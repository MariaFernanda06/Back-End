
class Sesi
{
    public static void Main()
    {
        //chamar e receber valor do metodo dobro
        double valorDobro = Dobro(8);

        //exibir o valor da variavel
        Console.WriteLine($"O dobro é {valorDobro}");

        double valorMetade = Metade(4);
        Console.WriteLine($"A metade é {valorMetade}");

        Console.WriteLine($"Digite um numero");
        int n = int.Parse(Console.ReadLine());
        ContagemTabuada(n);

        ResumoSalarios();

    }

    public static double Dobro(int Valor)
    {
        //criar variavel para calcular o dobro
        double resultado = Valor * 2;

        //retorntar o valor da função
        return resultado;
    }

    public static double Metade(int ValorM)
    {
        //criar variavel para calcular o dobro
        double resultadoM = ValorM / 2;

        //retorntar o valor da função
        return resultadoM;
    }

    public static void ContagemTabuada(int valor)
    {
        int n = 0;

        while (n <= 9)
        {
            n++;
            Console.WriteLine($"{n} X {valor} = {n * valor}");
        }

    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 1000000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do
        {
            Console.WriteLine("Digite o salário do empregado:");
            salarioEmpregado = int.Parse(Console.ReadLine());

            if (salarioEmpregado > 0)
                somaSalarios = somaSalarios + salarioEmpregado;
            //somaSalarios += salarioEmpregado; (recomendado usar)
            if (salarioEmpregado > maiorSalario)
            {
                maiorSalario = salarioEmpregado;
            }
            if (salarioEmpregado < menorSalario && salarioEmpregado > 0)
            {
                menorSalario = salarioEmpregado;
            }

        } while (salarioEmpregado > 0);

        Console.WriteLine($"A soma dos salários é {somaSalarios}, o maior salário é {maiorSalario} e o menor é {menorSalario}");
    }

}
