using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Contexto;
using Repository.Contratos;

namespace Repository
{
    public class GuardaSolRepository : IGuardaSolRepository
    {

        private readonly ContextCeara _context;
        public GuardaSolRepository(ContextCeara context)
        {
            _context = context;
        }
        public async Task<List<GuardaSol>> GetAllGuardaSolAsync()
        {
            IQueryable<GuardaSol> query = _context.GuardaSols
                .Include(p => p.Pedidos)
                .AsNoTracking();
                
            return await query.ToListAsync();
        }
        public async Task<GuardaSol> GetGuardaSolByIdAsync(int GuardaSolId)
        {
            IQueryable<GuardaSol> query = _context.GuardaSols
                .Include(p => p.Pedidos)
                .Where(i => i.Id == GuardaSolId)
                .AsNoTracking();
            return await query.FirstOrDefaultAsync();
        }
    }
}