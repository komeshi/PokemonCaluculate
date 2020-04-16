using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PokemonCaluculate.Data;
using PokemonCaluculate.Models;

namespace PokemonCaluculate.Pages.PokemonPersonality
{
    public class CreateModel : PageModel
    {
        private readonly PokemonCaluculate.Data.PokemonCaluculateContext _context;

        public CreateModel(PokemonCaluculate.Data.PokemonCaluculateContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Personality Personality { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Personality.Add(Personality);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
