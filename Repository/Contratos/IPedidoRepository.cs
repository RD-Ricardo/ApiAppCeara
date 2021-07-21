using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using System;

namespace Contratos.Repository
{
    public interface IPedidoRepository
    {
         Task<List<Pedido>> GetAllPedidosAsync();
         Task<List<Pedido>> GetALlPedidosDateAsync(DateTime dataPedido);

    }
}