using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
  [TestClass]

  public class ScrabbleLetterTests : IDisposable
  {
    public void Dispose()
    {
      ScrabbleLetter.ClearAll();
    }

    [TestMethod]
  
    public void ScrabbleLetter_CreateInstanceOfScrabbleLetter_Item()
    {
      ScrabbleLetter newWord = new ScrabbleLetter("test");
      Assert.AreEqual(typeof(ScrabbleLetter), newWord.GetType());
    }

    [TestMethod]

    public void ScrabbleLetter_ReturnInputtedValueForUserWord_String()
    {
      //Arrange
      string userWord = "test";
      ScrabbleLetter newWord = new ScrabbleLetter(userWord);
      
      //Act
      string result = newWord.Word;

      //Assert
      Assert.AreEqual(userWord, result);
    }

    [TestMethod]
    public void GetScore_ScoreOfEmptyWord_Zero()
    {
      //Arrange
      string userWord = "";
      ScrabbleLetter testScrabble = new ScrabbleLetter(userWord);
      int expectedScore = 0;

      //Act
      int actualScore = testScrabble.GetScore();

      //Assert
      Assert.AreEqual(expectedScore, actualScore);
    }

    [TestMethod]
    public void GetScore_ScoreOfOneCharWord_IntScore()
    {
      //Arrange
      string userWord = "e";
      ScrabbleLetter testScrabble = new ScrabbleLetter(userWord);
      int expectedScore = 1;

      //Act
      int actualScore = testScrabble.GetScore();

      //Assert
      Assert.AreEqual(expectedScore, actualScore);
    }

    [TestMethod]
    public void GetScore_ScoreOfOneCharCapital_IntScore()
    {
      //Arrange
      string userWord = "E";
      ScrabbleLetter testScrabble = new ScrabbleLetter(userWord);
      int expectedScore = 1;

      //Act
      int actualScore = testScrabble.GetScore();

      //Assert
      Assert.AreEqual(expectedScore, actualScore);
    }

    [TestMethod]
    public void GetScore_ScoreOfMultChars_IntScore()
    {
      //Arrange
      string userWord = "Elbow";
      ScrabbleLetter testScrabble = new ScrabbleLetter(userWord);
      int expectedScore = 10;

      //Act
      int actualScore = testScrabble.GetScore();

      //Assert
      Assert.AreEqual(expectedScore, actualScore);
    }

    [TestMethod]
    public void ReturnWordsList_ReturnsEmptyList_ScrabbleList()
    {
      //Arrange
      List<ScrabbleLetter> expectedList = new List<ScrabbleLetter> { };

      // Act
      List<ScrabbleLetter> resultList = ScrabbleLetter.ReturnWordsList();

      //Assert

      CollectionAssert.AreEqual(expectedList, resultList);
    }
  }
}

/*
Game starts
1. Create a new, blank list
X 2. Player enters word
X 3. Create ScrabbleLetter from word
4. Word added to list
X 5. Display score for word
6. Option to display total score
7. Repeat from 2
*/

// - add word
// - get whole list
// - get whole score (from list)