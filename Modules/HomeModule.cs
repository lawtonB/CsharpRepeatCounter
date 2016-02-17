using Nancy;
using FindReplace.Objects;
using System.Collections.Generic;
using System;

namespace FindReplaceProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      //loads index view at root//

      Post["/"] = _ => {
      FindReplacer newFindReplacer = new FindReplacer(Request.Form["phrase"], Request.Form["replace"], Request.Form["with-this"]);
      return View["results.cshtml", newFindReplacer];
      };
    }
  }
}
