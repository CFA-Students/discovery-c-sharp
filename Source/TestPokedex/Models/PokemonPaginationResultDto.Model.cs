using System.Collections.Generic;

namespace PocketMonsterIndex.Models
{
  public class PokemonPaginationResultDto
  {
    public int Count { get; set; }
    public string? Next { get; set; }
    public string? Previous { get; set; }
    public List<PokemonPaginationResultItem> Results { get; set; }
      = new List<PokemonPaginationResultItem>();

    public override string ToString() {
      return $"{Count} in total;{Next};{Previous};{Results.Count} pokemons now";
    }
  }
}