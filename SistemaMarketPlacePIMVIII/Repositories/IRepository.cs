using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public interface IRepository
    {
        Carrinho ObterPorId(int id);
        List<Carrinho> ObterTodos();
        CarrinhoRepository Adicionar(CarrinhoRepository carrinho);
void Adicionar(Carrinho carrinho);
    }
}
