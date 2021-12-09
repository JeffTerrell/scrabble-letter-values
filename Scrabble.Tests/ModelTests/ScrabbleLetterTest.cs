using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]

  public class ScrabbleLetterTests
  {
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
  }
}