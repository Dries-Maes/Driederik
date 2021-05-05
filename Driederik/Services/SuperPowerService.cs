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

        public async Task DeleteSuperPower(SuperPower superPower)
        {
            _context.SuperPowers.Remove(superPower);
            await _context.SaveChangesAsync();
        }
    }
}