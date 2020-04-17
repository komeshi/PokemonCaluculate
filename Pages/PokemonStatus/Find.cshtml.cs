using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokemonCaluculate.Models;

namespace PokemonCaluculate.Pages.PokemonStatus
{
    public class FindModel : PageModel
    {
        private readonly PokemonCaluculate.Data.PokemonCaluculateContext _context;                

        public FindModel(PokemonCaluculate.Data.PokemonCaluculateContext context)
        {
            _context = context;
        }

        public IList<Pokemon> Pokemons { get; set; }

        public async Task OnGetAsync(string Find)
        {
            Pokemons = await _context.Pokemon.Where(m => m.Name == Find).Take(1).ToListAsync();
        }

        public int HpCal(int Race,int Individual,int Effort,int Lv)
        {
            double HP = Math.Floor((Math.Floor((Race * 2) + Individual + (Effort / 4.0)) * Lv) / 100) + Lv + 10;
            int result = (int)HP;

            return result;
        }
    }
}