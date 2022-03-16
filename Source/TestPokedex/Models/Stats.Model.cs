using System.Collections.Generic;
using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class Stats
  {

    [JsonProperty("base_stat")]
    public int BaseStat { get; set; }
    public int Effort { get; set; }
    public List<StatsDetails> Stat { get; set; } = new List<StatsDetails>();
  }

}