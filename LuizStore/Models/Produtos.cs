using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuizStore.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorVenda { get; set; }
    }
}