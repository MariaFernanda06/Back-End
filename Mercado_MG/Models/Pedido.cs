namespace Produto
{
    public class Pedido
    {
        private int CodPedido { get; set; }
        private string Produtos { get; set; }
        private int Quantidade { get; set; }
        private string Endereco { get; set; }
        private string FormadePagamento { get; set; }

        public Pedido(int CodPedidoPessoa, string ProdutosPessoa, int QuantidadePessoa, string EnderecoPessoa, string FormadePagamentoPessoa)
        {

            this.CodPedido = CodPedidoPessoa;
            this.Produtos = ProdutosPessoa;
            this.Quantidade = QuantidadePessoa;
            this.Endereco = EnderecoPessoa;
            this.FormadePagamento = FormadePagamentoPessoa;
        }
}
}