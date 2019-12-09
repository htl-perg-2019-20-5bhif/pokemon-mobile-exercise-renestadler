using Newtonsoft.Json;

namespace PokemonExplorer.Dtos
{
    public class PokemonUrlsDto
    {
        [JsonProperty("results")]
        public PokemonUrlDto[] urls { get; set; }
    }
}
