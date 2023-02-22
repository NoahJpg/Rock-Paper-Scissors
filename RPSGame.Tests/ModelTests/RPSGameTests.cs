using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPSGame.Models;


namespace RPSGame.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    // Test methods go here
    [TestMethod]
    public void PlayerInput_AcceptAndStoreInputsFromUser_ExpectInputToExist()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.

      //Arrange
      string player1 = "rock";
      string player2 = "scissors";
      RockPaperScissors newGame = new RockPaperScissors();
      
      
      Assert.AreEqual(player1, "rock");
    }
  }
}