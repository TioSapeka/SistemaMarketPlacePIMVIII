using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Cliente
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Endereco_ID { get; set; }
        public Vendedor Endereco { get; set; }
    }
}
