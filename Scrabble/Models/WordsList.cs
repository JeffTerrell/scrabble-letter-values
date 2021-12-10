/* using System.Collections.Generic;

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
 */

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




//   public static void Main()
//   {
//     List<ScrabbleLetter> wordList = ScrabbleLetter.ReturnWordsList._wordsList(); // creates empty list for words
//     List<ScrabbleLetter> scoreList = ScrabbleLetter.ReturnWordsList._scoreList();  // empty list for scores
//     Console.WriteLine("Welcome to the Scrabble word score counter! 'Enter' a word or 'view' your score:");
//     string menuWord = Console.ReadLine();
//     if ( menuWord == "Enter")
//     {
//       Console.WriteLine("Please enter a word");
//       string userWord = Console.ReadLine();

//       ScrabbleLetter newWord = new ScrabbleLetter(userWord);
//       resultWordList = ScrabbleLetter.ReturnWordsList._wordsList();
//       resultScoreList = ScrabbleLetter.ReturnWordsList._scoreList();   newWord.GetScore()
//       try
//       {
//         Console.WriteLine($"Your word is worth {newWord.GetScore()} points");
//         Console.WriteLine("Current list of entered words with values");
//         foreach (ScrabbleLetter currentWord in resultWordList)
//         {
//           Console.WriteLine($"{currentWord.Word} - {newWord.GetScore()}");
//         }
//         Console.WriteLine($"Total Score is: {ScrabbleLetter.GetTotalScore()}");
//       }
//       catch (Exception)
//       {
//         Console.WriteLine("Word must only be letters");
//       }
//       Main();
//     }
//   }
// }



// for ( let i = 0; i < resultWordList.length ; i++) {
//   for (let i = 0; i < resultScoreList.length ; i++)
//   {
//     Console.WriteLine($"{resultWardList[i]} : {resultScoreList[i]}")
//   }
// }