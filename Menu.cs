namespace MathGame;

internal class Menu {
  internal void ShowMenu()
  {
    bool isGameOn = true;
    GameEngine gameEngine = new();
    do {
      Console.Clear();
      Console.WriteLine(@"Welcome to the Math Game! Please select from the options below:
      ------------------------
      V: Game History
      A: Addition
      S: Subtraction
      M: Multiplication
      D: Division
      Q: Quit Game
      ------------------------");

      var userInput = Helpers.ValidateNonEmptyString(Console.ReadLine());

      switch (userInput.ToLower()) {
        case "v":
          ScoreHistory.Display();
          break;
        case "a":
          gameEngine.AdditionGame();
          break;
        case "s":
          gameEngine.SubtractionGame();
          break;
        case "m":
          gameEngine.SubtractionGame();
          break;
        case "d":
          gameEngine.SubtractionGame();
          break;
        case "q":
          isGameOn = false;
          Console.Clear();
          Console.WriteLine("Goodbye!");
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid input. Please enter a valid selection. Press enter to go back to menu.");
          Console.ReadLine();
          break;
      }
    } while (isGameOn);
  }

  internal enum GameMode {
    Addition,
    Subtraction,
    Multiplication,
    Division
  }
}