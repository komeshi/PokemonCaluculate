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
    public class DeleteModel : PageModel
    {
        private readonly PokemonCaluculate.Data.PokemonCaluculateContext _context;

        public DeleteModel(PokemonCaluculate.Data.PokemonCaluculateContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Personality = await _context.Personality.FindAsync(id);

            if (Personality != null)
            {
                _context.Personality.Remove(Personality);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
