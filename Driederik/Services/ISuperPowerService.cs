using System.Collections.Generic;
using System.Threading.Tasks;

namespace Driederik.Services
{
    public interface ISuperPowerService
    {
        Task AddSuperPower(SuperPower superPower);
        Task DeleteSuperPower(SuperPower superPower);
        Task<SuperPower> GetSuperPower(int id);
        Task<IEnumerable<SuperPower>> GetSuperPowers();
        Task UpdateSuperPower(SuperPower superPower);
    }
}