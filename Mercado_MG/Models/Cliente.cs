namespace Login
{
    public class Cliente
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        private int CodCliente { get; set; }
        private int DataNascimento { get; set; }
        private string Email { get; set; }
        private string CEP { get; set; }
        private string Senha { get; set; }
        private int Telefone { get; set; }
        private int NumeroCasa { get; set; }

        public Cliente(string NomePessoa, string CPFPessoa, int CodClientePessoa, int DataNascimento, string EmailPessoa, string CEPPessoa, string SenhaPessoa, TelefonePessoa, NumeroCasaPessoa)
        {
            this.Nome = NomePessoa;
            this.CPF = CPFPessoa;
            this.CodCliente = CodClientePessoa;
            this.DataNascimento = DataNascimento;
            this.Email = EmailPessoa;
            this.CEP = CEPPessoa;
            this.Senha = SenhaPessoa;
            this.Telefone = TelefonePessoa;
            this.NumeroCasa = NumeroCasaPessoa;
        }
    }
}