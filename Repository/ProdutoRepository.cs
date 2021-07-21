using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contratos.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Contexto;

namespace Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ContextCeara  _context;
        public ProdutoRepository(ContextCeara context)
        {
            _context = context;
        }
        public async Task<List<Produto>> GetAllProdutosAsync()
        {
            IQueryable<Produto> query = _context.Produtos
                .Include(p => p.Pedidos)
                .AsNoTracking();
                return await query.ToListAsync();
        }
        public async Task<Produto> GetProdutoById(int ProdutoId)
        {
            IQueryable<Produto> query = _context.Produtos
                .Include(p => p.Pedidos)
                .Where(i => i.Id == ProdutoId)
                .AsNoTracking();
                return await query.FirstOrDefaultAsync();
        }
    }
}