//Exercicio 001 Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar em uma variavel do tipo string
Console.WriteLine("Digite o nome:");
string nomeAluno = (Console.ReadLine());

//Receber a nota 1, convertere armazenar em variavel int
Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());

//Receber a nota 2, convertere armazenar em variavel int
Console.WriteLine("Digite a nota 2:");
int nota2 = int.Parse(Console.ReadLine());

//Receber a nota 3, convertere armazenar em variavel int
Console.WriteLine("Digite a nota 3:");
int nota3 = int.Parse(Console.ReadLine());

//Declarar uma variavel do tipo int, para receber a média das notas
//(nota 1 + nota 2 + nota 3) / 3

int media = (nota1 + nota2 + nota3) / 3;

//Exibir uma mensagem se o aluno esta aprovado considerando nota acima de 7

if (media < 7)
{
    Console.WriteLine($"O Aluno {nomeAluno} foi reprovado com média {media}");
}
else
{
    Console.WriteLine($"O Aluno {nomeAluno} foi aprovado com média {media}");
}
