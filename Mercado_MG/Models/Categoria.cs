namespace Mercado
{
    public class Categoria
    {
        private string NomeCategoria { get; set; }
        private int CodCategoria { get; set; }

        public Categoria(string NomeCategoriaPessoa, int CodCategoriaPessoa)
        {
            this.NomeCategoria = NomeCategoriaPessoa;
            this.CodCategoria = CodCategoriaPessoa;
        }
    }
}