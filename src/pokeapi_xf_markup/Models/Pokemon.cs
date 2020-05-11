using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace pokeapi_xf_markup.Models
{
    public class Pokemon
    {
        //public List<Ability> Abilities { get; set; }
        public long BaseExperience { get; set; }
        //public List<Species> Forms { get; set; }
        //public List<GameIndex> GameIndices { get; set; }
        public long Height { get; set; }
        //public List<object> HeldItems { get; set; }
        public long Id { get; set; }
        public bool IsDefault { get; set; }
        //public Uri LocationAreaEncounters { get; set; }
        //public List<Move> Moves { get; set; }
        public string Name { get; set; }
        public long Order { get; set; }
        //public Species Species { get; set; }
        public Sprites Sprites { get; set; }
        //public List<Stat> Stats { get; set; }
        //public List<TypeElement> Types { get; set; }
        public long Weight { get; set; }
    }
}
