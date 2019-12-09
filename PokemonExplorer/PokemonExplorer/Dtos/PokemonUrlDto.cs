using Newtonsoft.Json;

namespace PokemonExplorer.Dtos
{
    public class PokemonUrlDto
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
