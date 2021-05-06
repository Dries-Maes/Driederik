using System.Collections.Generic;
using System.Threading.Tasks;

namespace Driederik.Services
{
    public interface ISuperPowerService
    {
        Task AddSuperPower(SuperPower superPower);
        Task DeleteSuperPowerAsync(int id);
        Task<SuperPower> GetSuperPower(int id);
        Task<IEnumerable<SuperPower>> GetSuperPowers();
        Task UpdateSuperPower(SuperPower superPower);
    }
}