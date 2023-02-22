using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using RPSGame.Models;

namespace RPSViewGame
{
  class Program
  {
    // static void Main(string[] args)
    static void Main()
    {

      RockPaperScissors game = new RockPaperScissors();
      string result = game.UserInputOption("rock", "scissors");
      Console.WriteLine(result);






      // WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      // builder.Services.AddControllersWithViews();

      // WebApplication app = builder.Build();

      // app.UseHttpsRedirection();
      // app.UseStaticFiles();
      // app.UseRouting();

      // app.MapControllerRoute(
      //   name: "default",
      //   pattern: "{controller=Home}/{action=Index}/{id?}"
      // );

      // app.Run();
    }
  }
}