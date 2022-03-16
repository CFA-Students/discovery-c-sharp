using PocketMonsterIndex.Services;
using PocketMonsterIndex.Models;

namespace PocketMonsterIndex
{
  public class App
  {
    readonly static PokemonService s_service = PokemonService.Instance;

    public async static Task Main(string[] args) {
      var endpoint = "pokemon?limit=5&offset=0";
      var dto = await s_service.FetchAs<PokemonPaginationResultDto>(endpoint);
      Console.WriteLine(dto.ToString());
      foreach (var result in dto.Results) {
        Console.Write(result.ToString());
      }
    }
  }
}