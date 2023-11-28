using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Carrinho
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
        public DateTime Data_Pedido { get; set; }
        public decimal Valor_total { get; set; }
        public int Status_Pedido_Id { get; set; }
        public Cliente? Cliente { get; set; }
        public int Client_Id { get; set; }
    }
}