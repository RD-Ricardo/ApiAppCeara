using System.Collections.Generic;

namespace Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public decimal Preco { get; set; }
        public string  Descricao { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}