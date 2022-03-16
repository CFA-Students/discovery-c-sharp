using System.Collections.Generic;
using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class PokemonInfoDto
  {
    public List<AbilityItem> Abilities { get; set; } = new List<AbilityItem>();
    [JsonProperty("base_experience")]
    public int BaseExperience { get; set; }
    public List<PokemonForm> Forms { get; set; } = new List<PokemonForm>();
    [JsonProperty("game_indices")]
    public List<GameIndice> GameIndices { get; set; } = new List<GameIndice>();
    [JsonProperty("held_items")]
    public List<object> HeldItems { get; set; } = new List<object>();
    [JsonProperty("is_default")]
    public bool IsDefault { get; set; } = false;
    [JsonProperty("location_area_encounters")]
    public string LocationAreaEncounters { get; set; } = "";
    public List<PokemonMoveItem> Moves { get; set; } = new List<PokemonMoveItem>();
    public string Name { get; set; } = "";
    public int Order { get; set; }
    [JsonProperty("past_types")]
    public List<object> PastTypes { get; set; } = new List<object>();
    public object Species { get; set; } = new object();
    public object Sprites { get; set; } = new object();
    public List<object> Stats { get; set; } = new List<object>();
    public List<object> Types { get; set; } = new List<object>();
    public string Weight { get; set; } = "";
  }
}
