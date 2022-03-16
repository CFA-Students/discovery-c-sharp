using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{

  public class PokemonOtherSpriteHome
  {
    [JsonProperty("front_default")]
    public string? FrontDefault { get; set; }

    [JsonProperty("front_female")]
    public string? FrontFemale { get; set; }

    [JsonProperty("front_shiny")]
    public string? FrontShiny { get; set; }

    [JsonProperty("front_shiny_female")]
    public string? FrontShinyFemale { get; set; }
  }
}