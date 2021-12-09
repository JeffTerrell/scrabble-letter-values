using System.Collections.Generic;

namespace Scrabble.Models
{

  public class ScrabbleLetter
  {
    public string Word { get; }
    private static List<ScrabbleLetter> _wordsList = new List<ScrabbleLetter> {};

    public static List<ScrabbleLetter> ReturnWordsList()
    {
      return _wordsList;
    }
    
    public static void ClearAll()
    {
      _wordsList.Clear();
    }

    public ScrabbleLetter(string word)
    {
      Word = word;
      _wordsList.Add(this);
    }

    
    public static int GetTotalScore()
    {
      //TODO
      return -1;
    }

    public int GetScore()
    {
      Dictionary<char, int> letterValues = new Dictionary<char, int>()
      {
        {'a', 1},
        {'e', 1},
        {'i', 1},
        {'o', 1},
        {'u', 1},
        {'l', 1},
        {'n', 1},
        {'r', 1},
        {'s', 1},
        {'t', 1},
        {'d', 2},
        {'g', 2},
        {'b', 3},
        {'c', 3},
        {'m', 3},
        {'p', 3},
        {'f', 4},
        {'h', 4},
        {'v', 4},
        {'w', 4},
        {'y', 4},
        {'k', 5},
        {'j', 8},
        {'x', 8},
        {'q', 10},
        {'z', 10}
      };
      int score = 0;
      char[] wordInChars = Word.ToLower().ToCharArray();
      foreach (char letter in wordInChars)
      {
        score += letterValues[letter];
      }
      return score;
    }

  }
}

// foreach (string groceryItem in myGroceryList)
// {
//   Console.WriteLine(groceryItem);
// }
// A, E, I, O, U, L, N, R, S, T       1
// D, G                               2
// B, C, M, P                         3
// F, H, V, W, Y                      4
// K                                  5
// Q, Z                               10



// User prompt to enter a word
// userWord = inputted word
// static field = Create dictionary to hold key value pairs for a letter (key) and its associated value (value)
// method : loop through the dictionary field and add to a totalScore when theres a match?
// Constructor : create instance with word stored

// > Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };