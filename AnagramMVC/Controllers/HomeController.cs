using Microsoft.AspNetCore.Mvc;
using AnagramMVC.Models;

namespace AnagramMVC.Controllers
{
  public class HomeController : Controller
  {

    [Route("/index")]
    public ActionResult Index() { return View(); }

    [Route("/output")]
    // public ActionResult Output() { return View(); }

    public ActionResult Output(string word, string words)
    {
      Anagram myLetterVariable = new Anagram();
      myLetterVariable.SetWord(word);
      myLetterVariable.SetWords(words);
      return View(myLetterVariable);
    }
  }
}
