using System.Collections.Generic;

namespace Domain
{
    public class Categoria 
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}