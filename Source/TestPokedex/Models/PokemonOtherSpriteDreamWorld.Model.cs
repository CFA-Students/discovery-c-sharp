using Newtonsoft.Json;
namespace PocketMonsterIndex.Models
{
  public class PokemonOtherSpriteDreamWorld
  {
    [JsonProperty("front_default")]
    public string? FrontDefault { get; set; }

    [JsonProperty("front_female")]
    public string? FrontFemale { get; set; }
  }
}