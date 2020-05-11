using System;
using System.Collections.Generic;

namespace pokeapi_xf_markup.Models
{
    public class PokeResult
    {
        public long Count { get; set; }
        public Uri Next { get; set; }
        public object Previous { get; set; }
        public List<NamedAPIResource> Results { get; set; }
    }
}
