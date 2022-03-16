using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class GameIndice
  {
    [JsonProperty("game_index")]
    public int GameIndex { get; set; }

    public GameIndiceVersion Version { get; set; } = new GameIndiceVersion();
  }
}