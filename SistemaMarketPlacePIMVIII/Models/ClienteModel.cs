using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class ClienteModel
    {
        //pk
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        //fk
        [ForeignKey(nameof(Endereco_Id))]
        public int Endereco_Id { get; set; }
    }
}
