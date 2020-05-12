namespace pokeapi_xf_markup.Models
{
    public class Pokemon
    {
        public long BaseExperience { get; set; }
        public long Height { get; set; }
        public long Id { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public long Order { get; set; }
        public Sprites Sprites { get; set; }
        public long Weight { get; set; }

        public string ImageFromt => Sprites is null ? string.Empty : Sprites.FrontDefault;
        public string ImageBack => Sprites is null ? string.Empty : Sprites.BackDefault;

        //public List<Stat> Stats { get; set; }
        //public Species Species { get; set; }
        //public Uri LocationAreaEncounters { get; set; }
        //public List<Move> Moves { get; set; }
        //public List<object> HeldItems { get; set; }
        //public List<Ability> Abilities { get; set; }
        //public List<Species> Forms { get; set; }
        //public List<GameIndex> GameIndices { get; set; }
        //public List<TypeElement> Types { get; set; }

    }
}
