using Pant.Model;

class Pantera
{

    public static void Main()
    {
        var pantera1 = new pantera();

        Console.WriteLine("Digite o tamanho de sua Pantera");
        pantera1.tamanho = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o peso de sua Pantera");
        pantera1.peso = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a cor de sua Pantera");
        pantera1.cor = Console.ReadLine();

        Console.WriteLine("Digite a espécie de sua Pantera");
        pantera1.especie = Console.ReadLine();

        Console.WriteLine("Digite a alimentação de sua Pantera");
        pantera1.alimentacao = Console.ReadLine();

        pantera1.respostas();
        pantera1.Correr();
        pantera1.Cacar();
        pantera1.Reproduzir();
    }
}
