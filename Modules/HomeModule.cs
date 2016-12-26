using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
                                                {
                                                  Recipient = "Jessica"
                                                };
        return View["hello.html"], myLetterVariables];
      }
    }
  }
}
