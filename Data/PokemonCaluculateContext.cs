using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCaluculate.Models;

namespace PokemonCaluculate.Data
{
    public class PokemonCaluculateContext : DbContext
    {
        public PokemonCaluculateContext (DbContextOptions<PokemonCaluculateContext> options)
            : base(options)
        {
        }

        public DbSet<PokemonCaluculate.Models.Pokemon> Pokemon { get; set; }
    }
}
