using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application.Contratos
{
    public interface ICategoriaService
    {
        Task<Categoria> AddCategoria(Categoria model);
        Task<Categoria> Update(int categoriaId ,Categoria model);
        Task<bool> DeleteCategoria(int categoriaId);
        Task<List<Categoria>> GettAllCategoriaAsync();
        Task<Categoria> GetCategoriaByIdAsync(int categoriaId);
    }
}