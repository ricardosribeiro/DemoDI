using DemoDI.Domain.Entities;
using System.Threading.Tasks;

namespace DemoDI.Domain.Interfaces
{
    public interface IProdutoService
    {
        Task<bool> ProdutoExistente(Produto produto);       
    }
}
