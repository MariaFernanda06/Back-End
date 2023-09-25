public class Program
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new{
            nome = "Maria",
            idade = 17
        };
        var pessoa2 = new{
            nome = "Gustavo",
            email = "gustavo@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e tem o email {pessoa2.email}");

        //pessoa1.nome = "Douglas";

        //Criar 2 objetos de classe anonima de carro

        var carro1 = new{
            marca = "VolksWagen",
            modelo = "Gol quadrado 1.40",
            ano = 1990
        };

        Console.WriteLine($"O carro é da marca {carro1.marca}, do modelo {carro1.modelo} do ano de {carro1.ano}");

        var carro2 = new{
            marca = "VolksWagen",
            modelo = "Gol Bolinha",
            ano = 2002
        };

        Console.WriteLine($"O carro é da marca {carro2.marca}, do modelo {carro2.modelo} do ano de {carro2.ano}");
    }
}