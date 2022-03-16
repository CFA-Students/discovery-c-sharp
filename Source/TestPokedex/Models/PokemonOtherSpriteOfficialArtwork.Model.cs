using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class PokemonOtherSpriteOfficialArtwork
  {
    [JsonProperty("front_default")]
    public string? FrontDefault { get; set; }
  }
}
