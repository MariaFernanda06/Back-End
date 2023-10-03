using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _19_Atividade.Models
{
    [Table("Produtos")]

    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        
        public decimal Preco { get; set; }
        
        [Required(ErrorMessage="Nome obrigatório")]
        [MaxLength(200, ErrorMessage="Descrição pode exceder {1} caracteres")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Estoque { get; set; }
    }
}

