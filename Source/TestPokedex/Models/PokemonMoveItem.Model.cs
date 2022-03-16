using System.Collections.Generic;

namespace PocketMonsterIndex.Models
{
  public class PokemonMoveItem
  {
    public PokemonMoveDetail Move { get; set; } = new PokemonMoveDetail();

    public List<object> VersionGroupDetails { get; set; } = new List<object>();
  }
}
