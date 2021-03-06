using System.Collections.Generic;

namespace Contact.Models
{
  public class Contact
  {
    private string _description;
    private static List<string> _instances = new List<string> {};

    public Contact (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_description);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
