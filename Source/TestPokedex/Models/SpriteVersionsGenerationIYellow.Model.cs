using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class SpriteVersionsGenerationIYellow
  {
    [JsonProperty("back_default")]
    public string? BackDefault { get; set; }

    [JsonProperty("back_gray")]
    public string? BackGray { get; set; }

    [JsonProperty("back_transparent")]
    public string? BackTransparent { get; set; }

    [JsonProperty("front_default")]
    public string? FrontDefault { get; set; }

    [JsonProperty("front_gray")]
    public string? FrontGray { get; set; }

    [JsonProperty("front_transparent")]
    public string? FrontTransparent { get; set; }
  }
}