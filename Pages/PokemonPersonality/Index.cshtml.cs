using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokemonCaluculate.Data;
using PokemonCaluculate.Models;

namespace PokemonCaluculate.Pages.PokemonPersonality
{
    public class IndexModel : PageModel
    {
        private readonly PokemonCaluculate.Data.PokemonCaluculateContext _context;

        public IndexModel(PokemonCaluculate.Data.PokemonCaluculateContext context)
        {
            _context = context;
        }

        public IList<Personality> Personality { get;set; }

        public async Task OnGetAsync()
        {
            Personality = await _context.Personality.ToListAsync();
        }
    }
}
