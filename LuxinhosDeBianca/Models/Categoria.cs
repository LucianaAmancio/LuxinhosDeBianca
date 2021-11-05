using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LuxinhosDeBianca.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100)]
        public string CategoriaNome { get; set; }

        [StringLength(500)]
        public string DescricaoDetalhada { get; set; }

        [StringLength(100)]
        public string DescricaoCurta { get; set; }

        [StringLength(100)]
        public string Preco { get; set; }

        public List<Produto> Produtos { get; set; }

    }
}
