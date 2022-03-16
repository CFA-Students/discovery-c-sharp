using Newtonsoft.Json;

namespace PocketMonsterIndex.Services
{
  // Forced structure for services
  public interface IPokemonService
  {
    // Find many pokemons asynchronously (over network)
    Task<T> FetchAs<T>(string endpoint);
  }

  // Base pokemon service = thread-safe singleton
  public sealed class PokemonService : IPokemonService
  {
    const string s_apiUrl = "https://pokeapi.co/api/v2/";
    readonly static object s_lock = new object();
    readonly static HttpClient s_httpClient = new HttpClient();
    static PokemonService? s_instance;

    PokemonService() { }

    // get the service, even if there is many threads
    public static PokemonService Instance {
      get {
        if (s_instance is null)
          lock (s_lock)
            if (s_instance is null)
              s_instance = new PokemonService();

        return s_instance;
      }
    }

    // Fetch an object as the type argument over network
    public async Task<T> FetchAs<T>(string endpoint) {
      var fullUrl = $"{s_apiUrl}{endpoint}";
      // Http object that holds the content
      HttpResponseMessage response = await s_httpClient.GetAsync(fullUrl);

      // if status code is not 200 (success)
      if (!response.IsSuccessStatusCode)
        throw new HttpRequestException("Cannot retrieve tasks (http error)");

      var jsonString = await response.Content.ReadAsStringAsync();

      // the useful object 
      var dataTransferObject = JsonConvert.DeserializeObject<T>(jsonString);

      if (dataTransferObject is null)
        throw new NullReferenceException("Cannot retrieve tasks (null error)");

      return dataTransferObject;
    }
  }

}