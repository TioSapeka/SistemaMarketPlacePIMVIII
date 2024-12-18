﻿using SistemaMarketPlacePIMVIII.Data;
using SistemaMarketPlacePIMVIII.Models;

namespace SistemaMarketPlacePIMVIII.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>
    {
        public ClienteRepository(BancoContext bancoContext) : base(bancoContext)
        {
        }
    }
}
