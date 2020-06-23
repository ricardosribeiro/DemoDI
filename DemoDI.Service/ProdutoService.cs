using DemoDI.Domain.Interfaces;
using System;
using System.Threading.Tasks;
using System.Linq;
using DemoDI.Domain.Entities;

namespace DemoDI.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<bool> ProdutoExistente(Produto produto)
        {
            var query = await _produtoRepository.ObterTodos();

            return query.Any(c => c.Nome.Equals(produto.Nome));
        }
    }
}
