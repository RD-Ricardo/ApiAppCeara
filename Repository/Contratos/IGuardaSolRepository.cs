using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Repository.Contratos
{
    public interface IGuardaSolRepository
    {
         Task<List<GuardaSol>> GetAllGuardaSolAsync();
         Task<GuardaSol> GetGuardaSolByIdAsync(int GuardaSolId);
    }
}