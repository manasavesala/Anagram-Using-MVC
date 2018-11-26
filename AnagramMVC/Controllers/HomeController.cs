using Microsoft.AspNetCore.Mvc;
using AnagramMVC.Models;

namespace AnagramMVC.Controllers
{
  public class HomeController : Controller
  {


    [Route("/result")]
    public ActionResult Result(string word, string[] words)
    {
      Anagram myLetterVariable = new Anagram();
      myLetterVariable.SetWord(word);
      myLetterVariable.SetWords(words);
      return View(myLetterVariable);
    }

    [Route("/index")]
    public ActionResult Index() { return View(); }


  }
}
