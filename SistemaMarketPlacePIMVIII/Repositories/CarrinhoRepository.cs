using SistemaMarketPlacePIMVIII.Data;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public class CarrinhoRepository : IRepository
    {
        private readonly BancoContext _bancoContext;
        public CarrinhoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;   
        }

        public List<Carrinho> ObterTodos()
        {
            return _bancoContext.Carrinho.ToList();
        }
        public CarrinhoRepository Adicionar(CarrinhoRepository carrinho)
        {
            _bancoContext.Carrinho.Add(carrinho);
            _bancoContext.SaveChanges();


            return carrinho;

        }

        public void Adicionar(Carrinho carrinho)
        {
           
        }

        public Carrinho ObterPorId(int id)
        {
            return _bancoContext.Carrinho.FirstOrDefault(x => x.ID == id);
        }

        public bool excluir(int id)
        {
            _bancoContext.Carrinho.Remove(Carrinho);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
