namespace ContactSaver {
  [Serializable()]
  public class Contact {
    string _number;

    public string Name;
    public string Number {
      get => _number;
      set => _verifyNumber(value);
    }

    // decomment this
    // public Contact() { }

    public Contact(string name, string number) {
      Name = name;
      _verifyNumber(number);
      if (_number is null) throw new NullReferenceException("_number is null");
    }

    void _verifyNumber(string value) {
      if (value.Length == 10 && _isDigitsOnly(value)) {
        _number = value;
      }
    }

    bool _isDigitsOnly(string str) {
      foreach (char c in str)
        if (c < '0' || c > '9')
          return false;
      return true;
    }

    public override string ToString() {
      return $"{Name}: {_number}";
    }
  }
}