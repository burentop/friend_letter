namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;
    private string _location;
    private string _altLocation;
    private string _souvenir;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }

    public string GetAltLocation()
    {
      return _altLocation;
    }

    public void SetAltLocation(string newAltLocation)
    {
      _altLocation = newAltLocation;
    }

    public string GetSouvenir()
    {
      return _souvenir;
    }

    public void SetSouvenir(string newSouvenir)
    {
      _souvenir = newSouvenir;
    }
  }
}
