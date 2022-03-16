using Newtonsoft.Json;
namespace PocketMonsterIndex.Models
{
  public class PokemonOtherSprite
  {
    [JsonProperty("dream_world")]
    public PokemonOtherSpriteDreamWorld DreamWorld { get; set; } = new PokemonOtherSpriteDreamWorld();

    public PokemonOtherSpriteHome Home { get; set; } = new PokemonOtherSpriteHome();

    [JsonProperty("dream_world")]
    public PokemonOtherSpriteOfficialArtwork OfficialArtwork { get; set; } = new PokemonOtherSpriteOfficialArtwork();
  }
}
