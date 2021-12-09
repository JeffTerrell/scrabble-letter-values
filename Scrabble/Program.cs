using System;
using System.Collections.Generic;
using Scrabble.Models;

class ScrabbleUI
{
  public static void Main()
  {
    Console.WriteLine("Enter your scrabble word:");
    string userWord = Console.ReadLine();
    ScrabbleLetter userScrabble = new ScrabbleLetter(userWord);
    try
    {
      Console.WriteLine($"Your word is worth {userScrabble.GetScore()} points");
    }
    catch (Exception)
    {
      Console.WriteLine("Word must only be letters");
    }
    Main();
  }
}


      // string userWord = "Elbow";
      // ScrabbleLetter testScrabble = new ScrabbleLetter(userWord);
      // int expectedScore = 10;

      // //Act
      // int actualScore = testScrabble.GetScore();