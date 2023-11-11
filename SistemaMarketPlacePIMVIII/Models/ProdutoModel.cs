using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class ProdutoModel
    {
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public bool Status { get; set; }
        public int Vendedor_ID { get; set; }
        public int Categoria_ID { get; set; }

        // Relacionamentos com Vendedor e Categoria
        public VendedorModel Vendedor { get; set; }
        public string Categoria { get; set; }

    }
}
