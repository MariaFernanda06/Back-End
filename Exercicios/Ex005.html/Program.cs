class Program
{
    public static void Main()
    {
        ListaDoChurrasco();

        //chamando outro método
        ListaSonhos();

    }

    public static void ListaDoChurrasco()
    {
        //declarar o vetor com 6 posições tipo string
         string[] lista = new string[6];

        //receber os produtos que precisam ser comprados
        for (int i = 0; i <6; i++)
        {
            //console para informar o produto a comprar
            Console.WriteLine("Informe o produto:");

            //declarando uma variavel produto para receber o que eu escrever no readline
            string produto = Console.ReadLine();

            //atribuir no meu vetor o produto que eu digitei pela posição
            lista[i] = produto;
        }

        //ordenar meu vetor 
        Array.Sort(lista);

        //para cada item na lista imprimir o produto
        foreach ( string item in lista)
        {
            Console.WriteLine(item);
        }

    }

    public static void ListaSonhos()
    {
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;

        for (int i = 0; i < 3; i++){
            Console.WriteLine($"Informe o seu {i}º sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {i}º sonho");
            decimal valor = decimal.Parse(Console.ReadLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }

        foreach(decimal val in valores)
        {
            total = total + val;
        }

        Console.WriteLine($"Seus sonhos custarão aprox. R${total}");

    }

}
