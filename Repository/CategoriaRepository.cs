using System.Collections.Generic;
using System.Threading.Tasks;
using Contratos.Repository;
using Domain;
using Repository.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ContextCeara _context;
        public CategoriaRepository(ContextCeara context)
        {
            _context = context;
        }
        public async Task<List<Categoria>> GetAllCategoriaAsync()
        {
            IQueryable<Categoria> query = _context.Categorias
                .Include(c => c.Produto)
                .AsNoTracking();
                return await query.ToListAsync();
        }
        public async Task<Categoria> GetCategoraById(int CategoriaId)
        {
            IQueryable<Categoria> query = _context.Categorias
                .Include(c => c.Produto);
                query = query.Where(c => c.Id ==  CategoriaId).OrderBy(e => e.Id);
                return await query.FirstOrDefaultAsync();
        }
    }
}