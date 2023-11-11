using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class CarrinhoModel
    {
        //pk
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_pedido { get; set; }
        public double Valor_total { get; set; }

        //fk
        [ForeignKey(nameof(Status_Pedido_Id))]
        public int Status_Pedido_Id { get; set; }

        [ForeignKey(nameof(Cliente_Id))]
        public int Cliente_Id { get; set; }
    }
}