using System.Collections.Generic;

namespace PocketMonsterIndex.Models
{
  public class Types
  {
    public int Slot { get; set; }
    public List<TypesDetails> Type { get; set; } = new List<TypesDetails>();
  }
}