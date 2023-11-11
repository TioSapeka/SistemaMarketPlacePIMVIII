using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Item_Carrinho
    {
        public string Quantidade { get; set; }
        public decimal Total { get; set; }

        // Relacionamentos com Carrinho e Produto
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(Carrinho))]
        public int Carrinho_ID { get; set; }
        //public CarrinhoModel Carrinho { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey(nameof(Produto))]
        public int Produto_ID { get; set; }
        //public ProdutoModel Produto { get; set; }
    }
}
