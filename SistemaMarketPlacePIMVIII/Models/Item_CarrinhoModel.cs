using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Item_CarrinhoModel
    {
        public string Quantidade { get; set; }
        public decimal Total { get; set; }

        // Relacionamentos com Carrinho e Produto
        [Key]
        [Column(Order = 1)]
        [ForeignKey(nameof(CarrinhoModel))]
        public int Carrinho_ID { get; set; }
        //public CarrinhoModel Carrinho { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey(nameof(ProdutoModel))]
        public int Produto_ID { get; set; }
        //public ProdutoModel Produto { get; set; }
    }
}
