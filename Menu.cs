namespace MathGame;

internal class Menu {
  internal void ShowMenu()
  {
    bool isGameOn = true;
    do {
      Console.Clear();
      Console.WriteLine(@"Welcome to the Math Game! Please select from the options below:
      V: Game History
      A: Addition
      S: Subtraction
      M: Multiplication
      D: Division
      Q: Quit Game
      ");

      var result = Console.ReadLine();

      switch (result.ToLower()) {
        case "v":
          Console.WriteLine("Game History");
          break;
        case "a":
          Console.WriteLine("Addition Game");
          break;
        case "s":
          Console.WriteLine("Subtraction Game");
          break;
        case "m":
          Console.WriteLine("Multiplication Game");
          break;
        case "d":
          Console.WriteLine("Division Game");
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
}