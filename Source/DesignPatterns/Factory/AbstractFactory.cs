namespace DesignPatterns.AbstractFactory;

// Factories
abstract class BaseMessageCreator {
  public abstract IMessage CreateMessage();

  public string SendMessage() {
    var message = CreateMessage();

    return $"Message Creator : {message.Render()}";
  }
}

class UserMessageCreator : BaseMessageCreator {
  public override IMessage CreateMessage() {
    return new UserMessage();
  }
}

class BotMessageCreator : BaseMessageCreator {
  public override IMessage CreateMessage() {
    return new BotMessage();
  }
}

// Products
public interface IMessage {
  string Render();
}

public class UserMessage : IMessage {
  public string Render() {
    return "User message";
  }
}

public class BotMessage : IMessage {
  public string Render() {
    return "Bot message";
  }
}

// App logic
class App {
  static void Main(string[] args) {
    Console.WriteLine("=== User mode ===");
    SendToClient(new UserMessageCreator());

    Console.WriteLine("");

    Console.WriteLine("=== Bot mode ===");
    SendToClient(new BotMessageCreator());
  }

  public static void SendToClient(BaseMessageCreator creator) {
    Console.WriteLine($"{creator.SendMessage()}");
  }
}
