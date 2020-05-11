using System.Collections.Generic;

namespace pokeapi_xf_markup.Models
{
    public class Move
    {
        public Species MoveMove { get; set; }
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }
}
