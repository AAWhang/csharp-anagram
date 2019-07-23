using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramCheck
    {
        public string WordChecker(string word, List<string> wordlist)
        {
          char[] wordArray = word.ToCharArray();
          Array.Sort(wordArray);
          string keyWord = string.Join("", wordArray);

          var fixedWords = new List<string>{};
          foreach (string words in wordlist)
          {
            char[] ListCharArray = words.ToCharArray();
            Array.Sort(ListCharArray);
            fixedWords.Add(string.Join("", ListCharArray));
          }

          var outputList = new List<string>{};

          for (int i = 0; i < fixedWords.Count; i++)
          {
            if (fixedWords[i] == keyWord)
              {
                outputList.Add(wordlist[i]);
              }
          }
           return outputList[0];

        }
    }
}
