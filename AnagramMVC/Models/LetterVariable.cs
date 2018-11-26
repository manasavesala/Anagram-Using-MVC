
using System;
using System.Linq;
using System.Collections.Generic;

namespace AnagramMVC.Models
{
  public class Anagram
  {
    private string _word;
    private string _words;

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string GetWords()
    {
      return _words;
    }

    public void SetWords(string newWords)
    {
      _words = newWords;
    }

    public string[] GetAnagrams()
    {
      string[] _words1 = _words.Split();
      _word = InOrder(_word);

      List<string> anagrams = new List<string>();
      for(int i=0; i < _words1.Length; i++)
      {
        var sortedWord = InOrder(_words1[i]);

        if(_word.Equals(sortedWord))
        {
          anagrams.Add(_words1[i]);
        }
      }
      string[] output = anagrams.ToArray();
      return output;
    }

    public string InOrder(string word)
    {
      char[] newWord = word.ToCharArray();
      Array.Sort(newWord);
      string sortedWord = string.Join("",newWord);
      return sortedWord;
    }
  }
}
