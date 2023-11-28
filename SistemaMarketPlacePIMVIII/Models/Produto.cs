using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Produto
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Imagem { get; set; }
        public bool Status { get; set; }
        public int Vendedor_ID { get; set; }
        public int Categoria_ID { get; set; }
        public Vendedor Vendedor { get; set; }
        public Categoria Categoria { get; set; }

    }
    public class Categoria
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
