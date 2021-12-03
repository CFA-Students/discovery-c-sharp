namespace Threads {
  public class TestThreadWorker {
    readonly int _count;

    Handler? _callback;

    public delegate void Handler(int i);
    public Handler? Callback;

    public TestThreadWorker(int count) {
      _count = count;
    }

    public TestThreadWorker(int count, Handler callback) {
      _count = count;
      _callback = callback;
    }

    public void ThreadLoop() {
      for (var i = 0; i < _count; i++) {
        Thread.Sleep(500);
        Console.WriteLine($"{i + 1}) I am working");
        if (_callback is not null)
          _callback(i);
      }
    }

  }
}
