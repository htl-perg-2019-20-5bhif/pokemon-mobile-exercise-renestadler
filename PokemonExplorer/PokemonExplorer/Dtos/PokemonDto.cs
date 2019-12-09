using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace PokemonExplorer.Dtos
{
    public class PokemonDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("abilities")]
        public ObservableCollection<AbilityDto> Abilities { get; set; }

        [JsonProperty("sprites")]
        public SpritesDto Sprites { get; set; }
    }
}
