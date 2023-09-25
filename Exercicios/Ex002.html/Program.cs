Console.WriteLine("Digite sua placa:");
string carroPlaca = (Console.ReadLine());

string ultimoNumero = carroPlaca.Substring(carroPlaca.Length - 1, 1);

Console.WriteLine($"O seu final é {ultimoNumero}");

if (ultimoNumero == "1" || ultimoNumero == "2")
{
    Console.WriteLine("Você não pode andar na Segunda!");
}
else if (ultimoNumero == "3" || ultimoNumero == "4")
{
    Console.WriteLine("Você não pode andar na Terça!");
}
else if (ultimoNumero == "5" || ultimoNumero == "6")
{
    Console.WriteLine("Você não pode andar na Quarta!");
}
else if (ultimoNumero == "7" || ultimoNumero == "8")
{
    Console.WriteLine("Você não pode andar na Quinta!");
}

else if (ultimoNumero == "9" || ultimoNumero == "0")
{
    Console.WriteLine("Você não pode andar na Sexta!");

}

