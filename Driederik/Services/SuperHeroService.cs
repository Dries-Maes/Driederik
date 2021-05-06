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

        public async Task<IEnumerable<SuperHero>> GetSuperHeroesAsync()
        {
            return await _context.SuperHeroes.ToListAsync();
        }

        public async Task<SuperHero> GetSuperHeroAsync(int id)
        {
            return await _context.SuperHeroes.FindAsync(id);
        }

        public async Task AddSuperHeroAsync(SuperHero superHero)
        {
            await _context.SuperHeroes.AddAsync(superHero);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSuperHeroAsync(int id)
        {
            var hero = new SuperHero { Id = id };
            _context.Attach(hero);
            _context.Update(hero);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSuperHeroAsync(int id)
        {
            var hero = new SuperHero { Id = id };
            _context.Attach(hero);
            _context.Remove(hero);
            await _context.SaveChangesAsync();
        }
    }
}