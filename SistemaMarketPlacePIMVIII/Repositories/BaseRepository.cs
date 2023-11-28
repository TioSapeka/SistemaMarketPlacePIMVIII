using Microsoft.EntityFrameworkCore;
using SistemaMarketPlacePIMVIII.Data;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly BancoContext _bancoContext;

        public BaseRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public List<T> ObterTodos()
        {
            return _bancoContext.Set<T>().ToList();
        }

        public T ObterPorId(int id)
        {
            return _bancoContext.Set<T>().Find(id);
        }

        public void  Atualizar(T entidade)
        {
            _bancoContext.Entry(entidade).State = EntityState.Modified;
            _bancoContext.SaveChanges();

        }


        public void Adicionar(T entidade)
        {
            _bancoContext.Set<T>().Add(entidade);
            _bancoContext.SaveChanges();

        }

        public void Excluir(T entidade)
        {
            _bancoContext.Set<T>().Remove(entidade);
            _bancoContext.SaveChanges();
         }  
    }
}
