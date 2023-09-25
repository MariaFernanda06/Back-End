Console.WriteLine("Digite o mês em número:");
int diaMes = int.Parse(Console.ReadLine());

switch (diaMes){
    case 1:
    Console.WriteLine("Mês de Janeiro, possui 31 dias ");
    break;
      case 2:
    Console.WriteLine("Mês de Fevereiro, possui 28 dias ");
    break;
      case 3:
    Console.WriteLine("Mês de Março, possui 31 dias ");
    break;
      case 4:
    Console.WriteLine("Mês de Abril, possui 30 dias ");
    break;
      case 5:
    Console.WriteLine("Mês de Maio, possui 31 dias ");
    break;
      case 6:
    Console.WriteLine("Mês de Junho, possui 30 dias ");
    break;
      case 7:
    Console.WriteLine("Mês de Julho, possui 31 dias ");
    break;
      case 8:
    Console.WriteLine("Mês de Agosto, possui 31 dias ");
    break;
      case 9:
    Console.WriteLine("Mês de Setembro, possui 30 dias ");
    break;
      case 10:
    Console.WriteLine("Mês de Outubro, possui 31 dias ");
    break;
      case 11:
    Console.WriteLine("Mês de Novembro, possui 30 dias ");
    break;
      case 12:
    Console.WriteLine("Mês de Dezembro, possui 31 dias ");
    break;
    default:
    Console.WriteLine("Mês inválido! ");
    break;
}
