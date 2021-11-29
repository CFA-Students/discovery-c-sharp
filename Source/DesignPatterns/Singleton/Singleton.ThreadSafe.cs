namespace DesignPatterns.Singleton.ThreadSafe
{
  public sealed class Singleton
  {
    static Singleton? _instance;

    private static readonly object _lock = new object();

    private Singleton() { }

    public string? Value { get; set; }

    public static Singleton GetInstance(string value)
    {
      if (_instance == null)
      {
        lock (_lock)
        {
          if (_instance == null)
          {
            _instance = new Singleton();
            _instance.Value = value;
          }
        }
      }

      return _instance;
    }
  }

  class App
  {
    static void Main(string[] args)
    {
      Console.WriteLine(
          "{0}\n{1}\n\n{2}\n",
          "If you see the same value, then singleton was reused (yay!)",
          "If you see different values, then 2 singletons were created (booo!!)",
          "RESULT:"
      );

      var process1 = new Thread(() =>
      {
        TestSingleton("FOO");
      });

      var process2 = new Thread(() =>
      {
        TestSingleton("BAR");
      });

      process1.Start();
      process2.Start();

      process1.Join();
      process2.Join();
    }

    public static void TestSingleton(string value)
    {
      var singleton = Singleton.GetInstance(value);
      Console.WriteLine(singleton.Value);
    }
  }
}
