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
    public class DetailsModel : PageModel
    {
        private readonly PokemonCaluculate.Data.PokemonCaluculateContext _context;

        public DetailsModel(PokemonCaluculate.Data.PokemonCaluculateContext context)
        {
            _context = context;
        }

        public Personality Personality { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Personality = await _context.Personality.FirstOrDefaultAsync(m => m.Id == id);

            if (Personality == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
