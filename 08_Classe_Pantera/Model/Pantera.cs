namespace Pant.Model
{
    public class pantera
    {
        public decimal tamanho { get; set; }
        public string cor { get; set; }
        public int peso { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void respostas()
        {
            Console.WriteLine($"A pantera {especie} possui {tamanho} metros, pesa {peso} Kg, tem cor {cor} e se alimenta de {alimentacao}");
        }

        public void Correr()
        {
            Console.WriteLine($"A pantera {especie} está correndo");
        }

        public void Cacar()
        {
            Console.WriteLine($"A pantera {especie} está caçando");
        }

        public void Reproduzir()
        {
            Console.WriteLine($"A pantera {especie} está em época de reprodução");
        }
    }
}

