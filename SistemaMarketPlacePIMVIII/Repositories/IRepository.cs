using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public interface IRepository
    {
        Carrinho ObterPorId(int id);
        List<Carrinho> ObterTodos();
        CarrinhoRepository Adicionar(CarrinhoRepository carrinho);
        bool excluir(int id);
void Adicionar(Carrinho carrinho);
    }
}
