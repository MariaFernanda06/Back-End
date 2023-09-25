Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritimeticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //Calculando o resto da divisão x / 2
int restoYDiv2 = y % 2;

//Console para exibir na tela as variáveis em cada linha
//soma: 15

Console.WriteLine($"A soma é: {soma}");

Console.WriteLine($"A subtração é: {subtracao}");

Console.WriteLine($"A multiplicação é: {multiplicacao}");

Console.WriteLine($"A  divisão é: {divisao}");

Console.WriteLine($"O  resto é: {resto}");

if (restoDiv2 == 0)
{
    Console.WriteLine($"O número {x} é par");
}
else
{
    Console.WriteLine($"O número {x} é ímpar");
}


if (restoYDiv2 == 0)
{
    Console.WriteLine($"O número {y} é par");
}
else
{
    Console.WriteLine($"O número {y} é ímpar");
}

//Operador trnário
//Condição "?" se verdade ":" senão
string resultado = (restoYDiv2 == 0) ? $"O número {y} é par" : $"O número {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 3;
//Aprendendo o Switch Case
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é Domingo!");
        break;
    case 2:
    Console.WriteLine("Hoje é Segunda!");
        break;
    case 3:
        Console.WriteLine("Hoje é Terça!");
        break;
    case 4:
        Console.WriteLine("Hoje é Quarta!");
        break;
    case 5:
        Console.WriteLine("Hoje é Quinta!");
        break;
    case 6:
        Console.WriteLine("Hoje é Sexta!");
        break;
    case 7:
        Console.WriteLine("Hoje é Sabado!");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}