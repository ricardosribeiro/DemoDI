using DemoDI.Domain.Entities;
using DemoDI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task<bool> Garvar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await Task.Run(() => GerarMockProdutos());
        }


        #region Mock
        public IEnumerable<Produto> GerarMockProdutos()
        {
            var produtos = new List<Produto>();
            for (int i = 0; i < 100; i++)
            {
                produtos.Add(new Produto($"Produto {i}", i * 0.2M));
            }

            return produtos;
        }

        #endregion


    }
}
