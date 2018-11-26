
using System;
using System.Linq;
using System.Collections.Generic;

namespace AnagramMVC.Models
{
  public class Anagram
  {
    private string _word;
    private string[] _words;

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string[] GetWords()
    {
      return _words;
    }

    public void SetWords(string[] newWords)
    {
      _words = newWords;
    }

    public string[] GetAnagrams(string word, string[] words)
    {
      word =GetWord();
      words = GetWords();
      word = InOrder(word);
      List<string> anagrams = new List<string>();
      for(int i=0; i < words.Length; i++)
      {
        var sortedWord = InOrder(words[i]);

        if(word.Equals(sortedWord))
        {
          anagrams.Add(words[i]);
        }
      }

      // List<string> --> string[]
      // List<int> --> int[]
      return anagrams.ToArray();
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
