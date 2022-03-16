namespace PocketMonsterIndex.Models
{
  public class Pokemon
  {
    private int _number;
    private string _name;
    private string _description;
    private int _height;
    private int _weight;
    private PokemonType[] _types;

    public int Number {
      get { return _number; }
    }

    public string Name {
      get { return _name; }
    }

    public string Description {
      get { return _description; }
    }

    public int Height {
      get { return _height; }
    }

    public int Weight {
      get { return _weight; }
    }

    public PokemonType[] Types {
      get { return _types; }
    }

    public Pokemon(int number, string name, string description, int height, int weight, PokemonType[] types) {
      _number = number;
      _name = name;
      _description = description;
      _height = height;
      _weight = weight;
      _types = types;
    }
  }
}