using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driederik.Services
{
    public class SuperPowerService : ISuperPowerService
    {
        private DriederikContext _context;

        public SuperPowerService(DriederikContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SuperPower>> GetSuperPowers()
        {
            return await _context.SuperPowers.ToListAsync();
        }

        public async Task<SuperPower> GetSuperPower(int id)
        {
            return await _context.SuperPowers.FindAsync(id);
        }

        public async Task AddSuperPower(SuperPower superPower)
        {
            await _context.SuperPowers.AddAsync(superPower);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSuperPower(SuperPower superPower)
        {
            _context.SuperPowers.Update(superPower);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSuperPowerAsync(int id)
        {
            var superpower = new SuperPower { Id = id };
            _context.Attach(superpower);
            _context.Remove(superpower);
            await _context.SaveChangesAsync();
        }
    }
}