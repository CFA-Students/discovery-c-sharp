using Newtonsoft.Json;

namespace PocketMonsterIndex.Models
{
  public class SpriteVersionsGenerationI
  {
    [JsonProperty("red-blue")]
    public SpriteVersionsGenerationIRedBlue RedBlue { get; set; } = new SpriteVersionsGenerationIRedBlue();
    public SpriteVersionsGenerationIYellow Yellow { get; set; } = new SpriteVersionsGenerationIYellow();
  }
}