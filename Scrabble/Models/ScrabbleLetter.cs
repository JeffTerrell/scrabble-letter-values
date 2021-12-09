

namespace Scrabble.Models
{

  public class ScrabbleLetter
  {
    public string Word { get; }

    public ScrabbleLetter(string word)
    {
      Word = word;
    }

    public int GetScore()
    {
      //TODO
      return -1;
    }
  }
}


// User prompt to enter a word
// userWord = inputted word
// static field = Create dictionary to hold key value pairs for a letter (key) and its associated value (value)
// method : loop through the dictionary field and add to a totalScore when theres a match?
// Constructor : create instance with word stored

