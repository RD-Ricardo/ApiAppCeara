using System.Collections.Generic;

namespace Domain
{
    public class GuardaSol
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public virtual  ICollection<Pedido> Pedidos { get; set; }
    }
}