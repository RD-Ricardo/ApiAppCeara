using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application.Contratos
{
    public interface IProdutoService
    {
        Task<Produto> AddProdutos(Produto model);
        Task<Produto> UpdateProdutos(int produtoId, Produto model);
        Task<bool> DeleteProdutos(int produtoId);
        Task<List<Produto>> GetAllProdutos();
        Task<Produto> GetProdutoById(int produtoId);
    }
}