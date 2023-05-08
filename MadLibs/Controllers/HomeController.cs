using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form()
    {
      return View(new Words());
    }

    [Route("/story")]
    public ActionResult Story(Words myWords)
    {
      string story = "Once upon a time, there was a " + myWords.Adjective1 + " " + myWords.Noun1 + ". It was " + myWords.Adverb1 + " " + myWords.Verb1 + " and " + myWords.Exclamation1 + "!";

      ViewBag.Story = story;
      ViewBag.MyWords = myWords;

      return View();
    }
  }
}