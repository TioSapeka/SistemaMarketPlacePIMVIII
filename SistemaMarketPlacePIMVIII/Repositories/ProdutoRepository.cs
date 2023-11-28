using SistemaMarketPlacePIMVIII.Data;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public ProdutoRepository(BancoContext bancoContext) : base(bancoContext)
        {
        }
    }
}
