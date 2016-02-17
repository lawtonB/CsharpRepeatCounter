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

      Get["/other_page"] = _ => {
      return View["template.cshtml"];
      };
    }
  }
}
