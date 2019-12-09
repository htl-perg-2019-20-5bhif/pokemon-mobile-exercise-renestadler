using Newtonsoft.Json;

namespace PokemonExplorer.Dtos
{
    public class SpritesDto
    {
        [JsonProperty("back_default")]
        public string Back_Default { get; set; }


        [JsonProperty("front_default")]
        public string Front_Default { get; set; }
    }
}
