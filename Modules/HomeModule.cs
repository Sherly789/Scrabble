using Nancy;
using System.Collections.Generic;

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
