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
// + GetScore();
// --- AddToWordsList(ScrabbleLetter scrabLetter)
// + CalcTotalScore()
// + view all words (display scorelist)

      // string userWord = "Elbow";
      // ScrabbleLetter testScrabble = new ScrabbleLetter(userWord);
      // int expectedScore = 10;

      // //Act
      // int actualScore = testScrabble.GetScore();
      // Player
      //  -> List of Scrabble Letters
      //  -> Total score

/*      class ToDoListUI
{
  public static void Main()
  {
    List<Item> result = Item.GetAll(); //this is empty list

    Console.WriteLine("Welcome to the 'To Do List' (Add/View)");
    string userInput  = Console.ReadLine();
    if ( userInput == "Add")
    {
      Console.WriteLine("Please enter an item to add to the list");
      string listItem = Console.ReadLine();

      Item newItem = new Item(listItem);
      result = Item.GetAll(); 
      Console.WriteLine("Your current 'To Do List' is :");
      int listOrder = 1; 
      foreach (Item thisItem in result)
      {
      Console.WriteLine(listOrder++ + ". " + thisItem.Description);
      }

      Console.WriteLine("Would you like to add another item (Yes/No)?");
      string userInputTwo = Console.ReadLine();
      if ( userInputTwo == "Yes")
      {  
        Main();     
      }
    }
    else if ( userInput == "View")
    {  
      int listOrderView = 1;
      Console.WriteLine("Updated 'To Do List'");
      foreach (Item thisItem in result)
      {
      Console.WriteLine(listOrderView++ + ". " + thisItem.Description);
      }
      Main();
    }
    else 
    {
      Console.WriteLine("Please Enter Add or View, Or press Control + C to exit");
      Main();
    }
  }
 */
