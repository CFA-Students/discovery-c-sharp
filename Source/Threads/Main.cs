namespace Threads {
  class App {
    const int _count = 12;

    public static void threadCallback(int i) {
      if (_count / 2 == i + 1)
        Console.WriteLine("Half of work done. Continuing...");

      if (_count == i + 1) Console.WriteLine("Work Done !");
    }

    public static void Main(string[] args) {
      var threadWorker = new TestThreadWorker(_count, threadCallback);
      var newThread = new Thread(new ThreadStart(threadWorker.ThreadLoop));

      newThread.Start();
    }
  }
}

