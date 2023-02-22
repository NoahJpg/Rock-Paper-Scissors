using System;
using System.Linq;


namespace RPSGame.Models
{
  public class RockPaperScissors
  {
    private readonly string[] _gameOptions = { "rock", "paper", "scissors", "" };
    private Random _random = new Random();
    private string _playerOneInput;
    private string _playerTwoInput;
    private string _computerInput;

    public string UserInputOption(string input1, string input2, string input3)
    {
      _playerOneInput = input1;
      _playerTwoInput = input2;
      _computerInput = input3;

      if (!_gameOptions.Contains(input1) || !_gameOptions.Contains(input2) || !_gameOptions.Contains(input3))
        throw new ArgumentException("Invalid choice");

      if (input1 == input2 || input1 == input3)
      {
        return "Tie";
      }
      else if (input1 == "rock" && input2 == "scissors" || input1 == "paper" && input2 == "rock" || input1 == "scissors" && input2 == "paper" || input1 == "rock" && input3 == "scissors" || input1 == "paper" && input3 == "rock" || input1 == "scissors" && input3 == "paper")
      {
        return "Player 1 Wins";
      }
      else if (input3 == "rock" && input1 == "scissors" || input3 == "paper" && input1 == "rock" || input3 == "scissors" && input1 == "paper")
      {
        return "Computer Wins!!!";
      }
      else
      {
        return "Player 2 Wins!!!";
      }
    }

    public string ComputerChoice()
    {
      int computerOption;
      do
      {
        computerOption = _random.Next(0, _gameOptions.Length);
      } while (computerOption == 3);

      return _gameOptions[computerOption];
    }
  }
}
