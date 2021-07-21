using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Contratos.Repository
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> GetAllProdutosAsync();
        Task<Produto> GetProdutoById(int ProdutoId);
    }
}