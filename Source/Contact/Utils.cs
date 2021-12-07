using System.Xml.Serialization;

namespace ContactSaver.Utils {
  public static class XmlUtils {
    public static void WriteXml(List<Contact> contacts, String path) {
      var writter = new XmlSerializer(typeof(List<Contact>));
      var file = File.Create(path);

      writter.Serialize(file, contacts);
      file.Close();
    }

    public static void ReadXml(String path) {
      var reader = new XmlSerializer(typeof(List<Contact>));
      var file = new StreamReader(path);
      var unknownObject = reader.Deserialize(file);
      file.Close();

      if (unknownObject is null) {
        Console.WriteLine("ERROR, file content is empty !");
        return;
      }

      var contacts = (List<Contact>) unknownObject;
      foreach (Contact contact in contacts) {
        Console.WriteLine(contact.ToString());
      }
    }
  }
}