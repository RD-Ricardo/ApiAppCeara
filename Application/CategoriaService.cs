using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Contratos;
using Contratos.Repository;
using Domain;
using Repository.Contratos.Genericos;

namespace Application
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IGenerico _generico;
        private readonly ICategoriaRepository _categoria;
        public CategoriaService(IGenerico generico, ICategoriaRepository categoria)
        {
            _categoria = categoria;
            _generico = generico;
        }
        public async Task<Categoria> AddCategoria(Categoria model)
        {
            _generico.Add<Categoria>(model);

            if(await _generico.SaveChangesAsync())
            {
                return await _categoria.GetCategoraById(model.Id);
            }

            return null;
        }
        public async Task<Categoria> Update(int categoriaId, Categoria model)
        {
            var result =  _categoria.GetCategoraById(categoriaId);
            _generico.Update(result);
            if(await _generico.SaveChangesAsync())
            {
                return await _categoria.GetCategoraById(model.Id);
            }

            return null;
        }

        public async Task<bool> DeleteCategoria(int categoriaId)
        {
            var result = _categoria.GetCategoraById(categoriaId);
            _generico.Delete(result);
            if(result == null) throw new System.Exception("Catgoria não encontrada");

            return await _generico.SaveChangesAsync();
        }

        public async Task<Categoria> GetCategoriaByIdAsync(int categoriaId)
        {
           var result =  _categoria.GetCategoraById(categoriaId);
           return  await result; 
        }

        public async Task<List<Categoria>> GettAllCategoriaAsync()
        {
            var result = _categoria.GetAllCategoriaAsync();
            return  await result;
        }       
    }
}