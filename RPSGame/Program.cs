using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using RPSGame.Models;

namespace RPSViewGame
{
  class Program
  {
  
    static void Main()
    {
      Console.WriteLine("1 or 2 players?:");
      string numOfPlayers = Console.ReadLine();
      if (numOfPlayers == "2")
      {
      Console.WriteLine("Player 1 = enter your choice of: rock, paper, or scissors");
      string input1 = Console.ReadLine().ToLower();
      Console.WriteLine("Player 2 = enter your choice of: rock, paper, or scissors");
      string input2 = Console.ReadLine().ToLower();
      string input3 = "";
      RockPaperScissors game = new RockPaperScissors();
      string result = game.UserInputOption(input1, input2, input3);
      Console.WriteLine(result);
      }
      else 
      {
      Console.WriteLine("Player 1 = enter your choice of: rock, paper, or scissors");
      RockPaperScissors game = new RockPaperScissors();
      string input1 = Console.ReadLine().ToLower();
      string input2 = "";
      string input3 = game.ComputerChoice();
      string newResult = game.UserInputOption(input1, input2, input3);
      Console.WriteLine("Player 1 chose " + input1 + ", and the computer chose " + input3 + ".");
      Console.WriteLine(newResult);
      }
      }
    }
  }
