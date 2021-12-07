using ContactSaver.Utils;

namespace ContactSaver {
  class App {
    static readonly string s_currentFolder = Directory.GetCurrentDirectory();

    public static void Main(string[] args) {
      Console.WriteLine("Contact saver");

      var slash = Path.DirectorySeparatorChar;
      var file = $"Source{slash}Contact{slash}contacts.xml";
      var path = Path.Combine(s_currentFolder, file);
      Console.WriteLine(path);

      var contacts = new List<Contact>();
      contacts.Add(new Contact("Jarod", "0123456789"));
      contacts.Add(new Contact("Test", "0123456789"));

      XmlUtils.WriteXml(contacts, path);
      XmlUtils.ReadXml(path);
      Console.ReadKey(true);
    }
  }
}