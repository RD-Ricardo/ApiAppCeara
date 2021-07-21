using System.Threading.Tasks;

namespace Repository.Contratos.Genericos
{
    public interface IGenerico
    {
        void Add<T>(T Entity) where T : class;
        void Update<T>(T Entity) where T : class;
        void Delete<T>(T Entity) where T : class;  
        Task<bool> SaveChangesAsync();
    }
}