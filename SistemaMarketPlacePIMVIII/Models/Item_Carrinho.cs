﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaMarketPlacePIMVIII.Models
{
    public class Item_Carrinho
    {
        [Key]
        public int Carrinho_ID { get; set; }
        public Carrinho Carrinho { get; set; }
        public int Produto_ID { get; set; }
        public Produto Produto { get; set; }
        public string Quantidade { get; set; }
        public decimal Total { get; set; }
    }
}
