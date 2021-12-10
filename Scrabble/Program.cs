using System;
using System.Collections.Generic;
using Scrabble.Models;

class ScrabbleUI
{
  public static void Main()
  {
    List<ScrabbleLetter> resultList = ScrabbleLetter.ReturnWordsList(); // creates empty list
    Console.WriteLine("Welcome to the Scrabble word score counter! 'Enter' a word or 'view' your score:");
    string menuWord = Console.ReadLine();
    if ( menuWord == "Enter")
    {
      Console.WriteLine("Please enter a word");
      string userWord = Console.ReadLine();

      ScrabbleLetter newWord = new ScrabbleLetter(userWord);
      resultList = ScrabbleLetter.ReturnWordsList();
      try
      {
        Console.WriteLine($"Your word is worth {newWord.GetScore()} points");
        Console.WriteLine("Current list of entered words with values");
        foreach (ScrabbleLetter currentWord in resultList)
        {
          Console.WriteLine($"{currentWord.Word} - {newWord.GetScore()}");
        }
        Console.WriteLine($"Total Score is: {ScrabbleLetter.GetTotalScore()}");
      }
      catch (Exception)
      {
        Console.WriteLine("Word must only be letters");
      }
      Main();
    }
  }
}