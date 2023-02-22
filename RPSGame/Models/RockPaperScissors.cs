using System;
using System.Linq;


namespace RPSGame.Models
{
  public class RockPaperScissors
  {
    private readonly string[] _gameOptions = {"rock", "paper", "scissors"};
    private string _playerOneInput;
    private string _playerTwoInput;

    public string UserInputOption(string input1, string input2)
    {
      _playerOneInput = input1;
      _playerTwoInput = input2;

    if (!_gameOptions.Contains(input1) || !_gameOptions.Contains(input2))
      throw new ArgumentException("Invalid choice");

      else if (input1 == input2)
      {  
        return "Tie";
      }
      else if (input1 == "rock" && input2 == "scissors" || input1 == "paper" && input2 == "rock" || input1 == "scissors" && input2 == "paper")
      {
        return "player1 Wins";
      }
      else
      {
        return "Player 2 Wins!!!";
      }
    }
  }
}