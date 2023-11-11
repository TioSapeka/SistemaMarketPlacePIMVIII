using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Vendedor
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public string Razao_Social { get; set; }
        public string Nome_Fantasia { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CNPJ { get; set; }
        public int Comissao { get; set; }
        public Endereco Endereco_ID { get; set; }
    }
}
