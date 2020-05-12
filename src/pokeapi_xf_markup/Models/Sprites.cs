using Newtonsoft.Json;

namespace pokeapi_xf_markup.Models
{
    public class Sprites
    {
        string backDefault;
        [JsonProperty("back_default")]
        public string BackDefault
        {
            get => backDefault ??= string.Empty;
            set => backDefault = value;
        }

        string backFemale;
        [JsonProperty("back_female")]
        public string BackFemale
        {
            get => backFemale ??= string.Empty;
            set => backFemale = value;
        }

        string backShiny;
        [JsonProperty("back_shiny")]
        public string BackShiny
        {
            get => backShiny ??= string.Empty;
            set => backShiny = value;
        }

        string backShinyFemale;
        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale
        {
            get => backShinyFemale ??= string.Empty;
            set => backShinyFemale = value;
        }

        string frontDefault;
        [JsonProperty("front_default")]
        public string FrontDefault
        {
            get => frontDefault ??= string.Empty;
            set => frontDefault = value;
        }

        string frontFemale;
        [JsonProperty("front_female")]
        public string FrontFemale
        {
            get => frontFemale ??= string.Empty;
            set => frontFemale = value;
        }

        string frontShiny;
        [JsonProperty("front_shiny")]
        public string FrontShiny
        {
            get => frontShiny ??= string.Empty;
            set => frontShiny = value;
        }

        string frontShinyFemale;
        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale
        {
            get => frontShinyFemale ??= string.Empty;
            set => frontShinyFemale = value;
        }
    }
}
