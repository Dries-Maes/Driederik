using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driederik
{
    public class DriederikContext : DbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }

        public DriederikContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}