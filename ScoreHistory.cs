namespace MathGame;

internal static class ScoreHistory {

  public static List<string> history = new List<string>();
  internal static void Display() {
    Console.Clear();
    Console.WriteLine("Games History:");
    Console.WriteLine("--------------------");
    foreach (string game in history) {
      Console.WriteLine(game);
    }
    Console.WriteLine("--------------------");
    Console.WriteLine("Please enter to continue back to menu.");
    Console.ReadLine();
  }

  internal static void AddToHistory(int score, Menu.GameMode gameMode) {
    history.Add($"{DateTime.Now} - {gameMode}: {score}");
  }
}