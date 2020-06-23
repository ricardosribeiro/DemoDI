using DemoDI.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoDI.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ObterTodos();
        Task<bool> Garvar(Produto produto);
    }
}
