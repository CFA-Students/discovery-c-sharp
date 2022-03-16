using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class VersionGroupDetailsItem
  {
    [JsonProperty("level_learned_at")]
    public int LevelLearnedAt { get; set; }

    public MoveLearnMethodDetails MoveLearnMethod { get; set; } = new MoveLearnMethodDetails();

    [JsonProperty("version_group")]
    public VersionGroupDetailsItemDetails VersionGroup { get; set; } = new VersionGroupDetailsItemDetails();
  }
}