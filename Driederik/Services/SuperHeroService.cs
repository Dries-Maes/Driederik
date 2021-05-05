using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driederik.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private DriederikContext _context;

        public SuperHeroService(DriederikContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SuperHero>> GetSuperHeroes()
        {
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<SuperHero> GetSuperHero(int id)
        {
            return await _context.SuperHeroes.FindAsync(id);
        }

        public async Task AddSuperHero(SuperHero superHero)
        {
            await _context.SuperHeroes.AddAsync(superHero);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSuperHero(SuperHero superHero)
        {
            _context.SuperHeroes.Update(superHero);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSuperHero(SuperHero superHero)
        {
            _context.SuperHeroes.Remove(superHero);
            await _context.SaveChangesAsync();
        }
    }
}