namespace PocketMonsterIndex.Models
{
  public class PokemonPaginationResultItem
  {
    public string Name { get; set; } = "";
    public string Url { get; set; } = "";

    public override string ToString() {
      var baseUrl = "https://pokeapi.co/api/v2";
      var endpointExtracted = Url.Substring(baseUrl.Length);
      return $"{Name}=>{endpointExtracted} ";
    }
  }
}