using System.Collections.Generic;

namespace Scrabble.Models
{
  public class WordsList
  {
    public int playerScore = 0;
    public static List<WordsList> scoreList = new List<WordsList> {};

    public AddToWordsList(ScrabbleLetter scrabLetter)
    {
      scoreList.Add(scrabLetter);
    }

    public CalcTotalScore()
    {
      foreach (string word in scoreList)
      {
        playerScore =+ word.GetValue();
      }
    }
  }
}

// > groceryList.Add("meatballs");

    // foreach (string groceryItem in myGroceryList)
    // {
    //   Console.WriteLine(groceryItem);
    // }
/*

List:
- word
- word

totalscore (list) = total score


user enters word:
that word value is found (scrabbleLetter.cs)
value is added to word/player list (scrabbleplayer.cs)
totalscore is calculated on the list (scrabbleplayer.cs)

Hello - 8
Total Score = 8

Hello - 8
Hello - 8
Total Score = 16


all words:
display the list. (for each loop) UI


*/