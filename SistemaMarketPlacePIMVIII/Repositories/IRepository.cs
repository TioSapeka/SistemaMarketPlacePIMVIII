using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public interface IRepository<T> where T : class
    {
        T ObterPorId(int id);
        List<T> ObterTodos();
        void Adicionar(T entidade);
        void Excluir(T entidade);
        void Atualizar(T entidade);
    }
}
