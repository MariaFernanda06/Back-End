class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pele {i}ª vez no for");
        }

        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($" A variavel sesi vale {sesi}");
        }

        int numero = 87;
        for(int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{numero} X {cont} = {numero*cont}");
        }

        //Declarando um vetor com 34 posições
        string[] alunos = new string[35];

        //Atribuindo valores ao nosso vetor
        alunos[1] = "Abner";
        alunos[2] = "Adalberto";
        alunos[3] = "Ana";
        alunos[34] = "Samuel";

        foreach (string aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int Laura = 0; //soma
        int Jorge = 0; //maior
        int Bianca = 100; //menor
        foreach (int Enzo in cadeiras)
        {
            Laura = Laura + Enzo;
            if(Enzo > Jorge){
                Jorge = Enzo;
            }
            if(Enzo < Bianca){
                Bianca = Enzo;
            }
        }
        Console.WriteLine($"Soma: {Laura}, Maior {Jorge}, Menor {Bianca}");

        for (int x = 0; x < cadeiras.Length ; x++){
            Console.WriteLine($"Pos {x} - valor {cadeiras[x]}");
        }
        Array.Sort(cadeiras);
    }

}