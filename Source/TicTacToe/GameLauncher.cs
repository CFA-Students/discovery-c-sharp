namespace TicTacToe {
  static class GameLauncher {
    public static void RunApp() {
      Console.WriteLine("=== TicTacToe ===");

      var game = new Game();

      var exitGame = false;
      do {
        game.DisplayGrid();
        game.SelectSlotForCurrentPlayer();
        game.DetectEndOfGame();

        exitGame = game.HasAWinner || game.IsDrawMatch;
      } while (!exitGame);

      if (game.IsDrawMatch)
        Console.WriteLine("It's a draw...");
      else if (game.HasAWinner)
        Console.WriteLine($"Player {game.CurrentPlayer} has won !!");
      else
        Console.WriteLine("OOPS ! ERRROOOOORRR !!!");
    }
  }
}
