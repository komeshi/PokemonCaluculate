using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonCaluculate.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Display(Name = "名前")]
        public string Name { get; set; }

        [Display(Name = "タイプ1")]
        public string Type1 { get; set; }

        [Display(Name = "タイプ2")]
        public string Type2 { get; set; }

        [Display(Name = "特性1")]
        public string Ability1 { get; set; }

        [Display(Name = "特性2")]
        public string Ability2 { get; set; }

        [Display(Name = "夢特性")]
        public string HiddenAbliity { get; set; }

        [Display(Name = "HP")]
        public int Hitpoint { get; set; }

        [Display(Name = "攻撃")]
        public int Attack { get; set; }

        [Display(Name = "防御")]
        public int Block { get; set; }

        [Display(Name = "特攻")]
        public int Contact { get; set; }

        [Display(Name = "特防")]
        public int Defense { get; set; }

        [Display(Name = "素早さ")]
        public int Speed { get; set; }

        [Display(Name = "最終進化")]
        public bool EvolutionJudge { get; set; }

        [Display(Name = "画像パス")]
        public string IconPass { get; set; }
    }
}
