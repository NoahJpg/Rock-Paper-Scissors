using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSGame.Models;
using System;


namespace RPSGame.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    // Test methods go here
    // [TestMethod]
    // public void PlayerInput_AcceptAndStoreInputsFromUser_ExpectInputToExist()
    // {

    //   //Arrange
    //   string player1 = "rock";
    //   RockPaperScissors newGame = new RockPaperScissors();
      
    //   //Act
    //   string result = newGame(player1);

    //   //Assert
    //   Assert.AreEqual(player1, "rock");
    // }

    [TestMethod]
    public void UserInput_DeterminesWinnerBasedOnLogic_Player2Wins()
    {

      // Arrange
      RockPaperScissors newGame = new RockPaperScissors();
      string player1Input = "paper";
      string player2Input = "scissors";

      // Act
      string result = newGame.UserInputOption(player1Input, player2Input);
      
      // Assert

      Assert.AreEqual("Player 2 Wins!!!", result);
    }
  }
}