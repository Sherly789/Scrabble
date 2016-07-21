using Nancy;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => "Hello";
    }
  }
}
