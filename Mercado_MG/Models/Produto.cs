namespace Item
{
    public class Produto
    {
        private int CodProduto { get; set; }
        private string Img { get; set; }
        private decimal Valor { get; set; }
        private string Descricao { get; set; }
        private string NomeProduto { get; set; }

        public Produto( int CodProdutoPessoa, string ImgPessoa, decimal ValorPessoa, string DescricaoPessoa, string NomeProdutoPessoa)
        {
            this.CodProduto = CodProdutoPessoa;
            this.Img = ImgPessoa;
            this.Valor = ValorPessoa;
            this.Descricao = DescricaoPessoa;
            this.NomeProduto = NomeProdutoPessoa;
        }
    }
}