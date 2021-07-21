using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Contratos;
using Contratos.Repository;
using Domain;
using Repository.Contratos.Genericos;

namespace Application
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IGenerico _generico;
        public ProdutoService(IProdutoRepository produtoRepository, IGenerico generico)
        {
            _produtoRepository = produtoRepository;
            _generico = generico;
        }
        public async Task<Produto> AddProdutos(Produto model)
        {
            _generico.Add<Produto>(model);
            if(await _generico.SaveChangesAsync()) 
            {
                return await _produtoRepository.GetProdutoById(model.Id);
            }
            return null;
        }

        public async Task<bool> DeleteProdutos(int produtoId)
        {
            var result = await _produtoRepository.GetProdutoById(produtoId);
            _generico.Delete(result);
            if(result == null) throw new System.Exception("Não encontrado");
            return await _generico.SaveChangesAsync();
        }

        public async Task<List<Produto>> GetAllProdutos() 
        {
            return await _produtoRepository.GetAllProdutosAsync();
        }   
        public async Task<Produto> GetProdutoById(int produtoId)
        {
            var result = await _produtoRepository.GetProdutoById(produtoId);
            if(result == null) return null;
            return result;
        }

        public async Task<Produto> UpdateProdutos(int produtoId, Produto model)
        {
            var result = await _produtoRepository.GetProdutoById(produtoId);
            _generico.Update(result);
            if(await _generico.SaveChangesAsync())
            {
                return await _produtoRepository.GetProdutoById(model.Id);
            }
            return null;
        }
    }
}