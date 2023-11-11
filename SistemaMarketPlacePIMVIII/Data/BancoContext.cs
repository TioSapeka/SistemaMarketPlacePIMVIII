using Microsoft.EntityFrameworkCore;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Data
{
    public class BancoContext : DbContext

    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categoria { get; set; }
        //public DbSet<Endereco> Endereco { get; set; }
        //public DbSet<Cliente> Cliente { get; set; }
        //public DbSet<Carrinho> Carrinho { get; set; }
        //public DbSet<Item_Carrinho> Item_Carrinho { get; set; }
        //public DbSet<Produto> Produto { get; set; }

    }
}
