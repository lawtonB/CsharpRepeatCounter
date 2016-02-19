// using Nancy;
// using RepeatCount.Objects;
// using System.Collections.Generic;
// using System;
//
// namespace RepeatCounterProject
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ => View ["index.cshtml"];
//       //loads index view at root//
//
//       Post["/"] = _ => {
//       RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["phrase"]);
//       return View["results.cshtml", newRepeatCounter];
//       };
//     }
//   }
// }
