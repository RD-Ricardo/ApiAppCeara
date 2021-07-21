using System.Threading.Tasks;
using Repository.Contexto;
using Repository.Contratos.Genericos;

namespace Application
{
    public class GenericoRepository : IGenerico
    {
        private readonly ContextCeara _context;
        public GenericoRepository(ContextCeara context)
        {
            _context = context;
        }

        public void Add<T>(T Entity) where T : class
        {
            _context.Add(Entity);
        }

        public void Delete<T>(T Entity) where T : class
        {
            _context.Remove(Entity);
        }

        public  async Task<bool> SaveChangesAsync()
        {
            var result =  await _context.SaveChangesAsync() > 1;
            return result;
        }

        public void Update<T>(T Entity) where T : class
        {
            _context.Update(Entity);
        }
    }
}