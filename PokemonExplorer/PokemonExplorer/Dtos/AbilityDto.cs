using Newtonsoft.Json;

namespace PokemonExplorer.Dtos
{
    public class AbilityDto
    {
        [JsonProperty("ability")]
        public Ability Ability { get; set; }
    }
}
