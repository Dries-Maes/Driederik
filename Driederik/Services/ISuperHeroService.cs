using System.Collections.Generic;
using System.Threading.Tasks;

namespace Driederik.Services
{
    public interface ISuperHeroService
    {
        Task AddSuperHero(SuperHero superHero);
        Task DeleteSuperHero(SuperHero superHero);
        Task<SuperHero> GetSuperHero(int id);
        Task<IEnumerable<SuperHero>> GetSuperHeroes();
        Task UpdateSuperHero(SuperHero superHero);
    }
}