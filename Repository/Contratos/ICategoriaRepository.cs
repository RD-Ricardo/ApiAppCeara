using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Contratos.Repository
{
    public interface ICategoriaRepository
    {
         Task<List<Categoria>> GetAllCategoriaAsync();
         Task<Categoria> GetCategoraById(int CategoriaId);
    }
}