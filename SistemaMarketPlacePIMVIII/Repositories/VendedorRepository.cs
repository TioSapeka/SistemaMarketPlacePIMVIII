using SistemaMarketPlacePIMVIII.Data;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public class VendedorRepository : BaseRepository<Vendedor>
    {
        public VendedorRepository(BancoContext bancoContext) : base(bancoContext)
        {
        }
    }
}
