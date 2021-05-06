using System.Collections.Generic;
using System.Threading.Tasks;

namespace Driederik.Services
{
    public interface ISuperHeroService
    {
        Task AddSuperHeroAsync(SuperHero superHero);
        Task DeleteSuperHeroAsync(int id);
        Task<SuperHero> GetSuperHeroAsync(int id);
        Task<IEnumerable<SuperHero>> GetSuperHeroesAsync();
        Task UpdateSuperHeroAsync(int id);
    }
}