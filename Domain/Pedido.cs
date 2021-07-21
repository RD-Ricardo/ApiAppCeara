using System;
using System.Collections.Generic;

namespace Domain
{
    public class Pedido
    {
        public Pedido()
        {
            this.Hora = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime Hora { get; set; }
        public int  Quantidade { get; set; }
        public string Observacao { get; set; }
        public int GuardaSolId { get; set; }
        public virtual GuardaSol  GuardaSol { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}