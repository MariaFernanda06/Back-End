using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //Criando uma lista de inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos a lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        Console.WriteLine(listaNumeros[2]);

        //Contagem de elementos
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");


        Console.WriteLine("##################################################");
        List<string> listaNomes = new List<string>();
        listaNomes.Add("Maria Fernanda"); //posição [0]
        listaNomes.Add("Gustavo"); //posição [1]
        listaNomes.Add("Fabiano"); //posição [2]
        Console.WriteLine(listaNomes[0]);
        Console.WriteLine(listaNomes[1]);
        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Neste momento temos {listaNomes.Count} elementos");
        Console.WriteLine("##################################################");


        //Criando uma lista de numeros ja atribuidos
        List<int> numeros = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"Quantidade de elemetos na lista números: {numeros.Count}");
        numeros.Remove(2); //remover o elemento 
        numeros.RemoveAt(1); //remove o elemento no índice 1
        numeros.RemoveRange(2, 2); //remove 2 elementos a paratir do índice 2

        //substituindo informação do item da lista
        numeros[0] = 100;

        //Interando sobre todos da lista de numeros
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //foreach da lista de nomes
        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        //criando uma lista com objetos da classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno á minha lista
        Aluno novoAluno = new Aluno("Gustavo", 17);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Duda", 15));

        //Exibindo lista de alunos
        Console.WriteLine("Lista Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }

        //Criando uma nova lista, ordenando por nome
        //LINQ utilizando sintaxe de consulta
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        //LINQ utilizando sintaxe de método
        var consulta = listaAlunos
                        .Where(aluno => aluno.idade == 17)
                        .OrderBy(aluno => aluno.nome);

        foreach(var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
    }
}