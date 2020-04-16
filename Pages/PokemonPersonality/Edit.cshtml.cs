using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokemonCaluculate.Data;
using PokemonCaluculate.Models;

namespace PokemonCaluculate.Pages.PokemonPersonality
{
    public class EditModel : PageModel
    {
        private readonly PokemonCaluculate.Data.PokemonCaluculateContext _context;

        public EditModel(PokemonCaluculate.Data.PokemonCaluculateContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Personality).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalityExists(Personality.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonalityExists(int id)
        {
            return _context.Personality.Any(e => e.Id == id);
        }
    }
}
