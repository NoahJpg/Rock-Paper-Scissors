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
      Console.WriteLine("Player 1 = enter your choice of: rock, paper, or scissors");
      string input1 = Console.ReadLine().ToLower();
      Console.WriteLine("Player 2 = enter your choice of: rock, paper, or scissors");
      string input2 = Console.ReadLine().ToLower();
      RockPaperScissors game = new RockPaperScissors();
      string result = game.UserInputOption(input1, input2);
      Console.WriteLine(result);

      
    }
  }
}