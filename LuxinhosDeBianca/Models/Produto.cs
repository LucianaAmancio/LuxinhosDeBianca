using System.ComponentModel.DataAnnotations;

namespace LuxinhosDeBianca.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string ModeloEstilo { get; set; }

        [StringLength(200)]
        public string Preco { get; set; }

        [StringLength(200)]
        public string ImagemUrl { get; set; }

        public bool IsProdutoPreferido { get; set; }

        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }


    }
}
