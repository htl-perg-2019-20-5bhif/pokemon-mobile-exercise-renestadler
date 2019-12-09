using Newtonsoft.Json;

namespace PokemonExplorer.Dtos
{
    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
