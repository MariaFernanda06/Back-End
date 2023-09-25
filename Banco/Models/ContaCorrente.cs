namespace Banco
{
    public class ContaCorrente
    {
        private double Saldo { get; set; }
        private string Titular { get; set; }

        public ContaCorrente(string TitularPessoa)
        {
            this.Saldo = 0;
            this.Titular = TitularPessoa;
        }

        public void BemVindo()
        {
            Console.WriteLine($"Bem vindo(a), {Titular}");
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo é de {Saldo}R$");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo = valor + Saldo;
                Console.WriteLine("Valor depositado, verifique seu saldo !");
            }else{
                Console.WriteLine("Valor inválido !");
            }
        }

        public void Sacar(double Valor)
        {
            if (Valor > 0)
            {
                Saldo = Saldo - Valor;
                Console.WriteLine("Valor sacado, verifique seu saldo !");
            }else{
                Console.WriteLine("Valor de saque inválido !");
            }
        }
    }
}