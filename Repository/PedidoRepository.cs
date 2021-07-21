using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contratos.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using Repository.Contexto;

namespace Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ContextCeara _context;
        public PedidoRepository(ContextCeara context)
        {
            _context = context;
        }
        public async Task<List<Pedido>> GetAllPedidosAsync()
        {
            IQueryable<Pedido> query = _context.Pedidos
                .Include(c => c.GuardaSol)
                .Include(c => c.Produtos)
                .AsNoTracking(); 
            return  await query.ToListAsync();
        }

        public async Task<List<Pedido>> GetALlPedidosDateAsync(DateTime dataPedido)
        {
            IQueryable<Pedido> query = _context.Pedidos
                .Include(g => g.GuardaSol)
                .Include(p => p.Produtos)
                .Where(h => h.Hora == dataPedido)
                .OrderBy(o => o.Hora)
                .AsNoTracking();
                return await query.ToListAsync();
        }
    }
}