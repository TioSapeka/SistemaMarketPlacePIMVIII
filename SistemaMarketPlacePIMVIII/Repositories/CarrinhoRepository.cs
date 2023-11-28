using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Plugins;
using SistemaMarketPlacePIMVIII.Data;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public class CarrinhoRepository : BaseRepository<Carrinho>
    {
        public CarrinhoRepository(BancoContext bancoContext) : base(bancoContext)
        {
        }
    }
}
