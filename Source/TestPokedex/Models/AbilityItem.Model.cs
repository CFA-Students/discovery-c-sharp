using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class AbilityItem
  {
    public AbilityDetails Ability { get; set; } = new AbilityDetails();

    [JsonProperty("is_hidden")]
    public bool IsHidden { get; set; } = false;

    public int Slot { get; set; }

  }
}