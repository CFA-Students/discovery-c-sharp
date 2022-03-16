using Newtonsoft.Json;
namespace PocketMonsterIndex.Models
{
  public class PokemonSprite
  {
    [JsonProperty("back_default")]
    public string? BackDefault { get; set; }

    [JsonProperty("back_female")]
    public string? BackFemale { get; set; }

    [JsonProperty("back_shiny")]
    public string? BackShiny { get; set; }

    [JsonProperty("back_shiny_female")]
    public string? BackShinyFemale { get; set; }

    [JsonProperty("front_default")]
    public string? FrontDefault { get; set; }

    [JsonProperty("front_female")]
    public string? FrontFemale { get; set; }

    [JsonProperty("front_shiny")]
    public string? FrontShiny { get; set; }

    [JsonProperty("front_shiny_female")]
    public string? FrontShinyFemale { get; set; }

    public PokemonOtherSprite Other { get; set; } = new PokemonOtherSprite();

    public PokemonSpriteVersions Versions { get; set; } = new PokemonSpriteVersions();
  }
}