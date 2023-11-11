using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Categoria
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
