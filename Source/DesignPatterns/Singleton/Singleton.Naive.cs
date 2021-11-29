namespace DesignPatterns.Singleton.Naive {
  public sealed class Singleton {
    static Singleton? _instance;

    private Singleton() { }

    public static Singleton GetInstance() {
      if (_instance is null) {
        _instance = new Singleton();
      }
      return _instance;
    }

    public void businessLogic() { }
  }


  class App {
    static void Main(string[] args) {
      var s1 = Singleton.GetInstance();
      var s2 = Singleton.GetInstance();

      if (s1 == s2)
        Console.WriteLine("Singleton works, both variables contain the same instance.");
      else
        Console.WriteLine("Singleton failed, variables contain different instances.");
    }
  }
}