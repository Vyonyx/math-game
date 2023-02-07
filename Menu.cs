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
      ------------------------");

      var userInput = Helpers.ValidateNonEmptyString(Console.ReadLine());

      switch (userInput.ToLower()) {
        case "v":
          Console.Clear();
          Console.WriteLine("Game History");
          Console.WriteLine("Press enter to return back to menu.");
          Console.ReadLine();
          break;
        case "a":
          Console.Clear();
          Console.WriteLine("Addition Game");
          Console.WriteLine("Press enter to return back to menu.");
          Console.ReadLine();
          break;
        case "s":
          Console.Clear();
          Console.WriteLine("Subtraction Game");
          Console.WriteLine("Press enter to return back to menu.");
          Console.ReadLine();
          break;
        case "m":
          Console.Clear();
          Console.WriteLine("Multiplication Game");
          Console.WriteLine("Press enter to return back to menu.");
          Console.ReadLine();
          break;
        case "d":
          Console.Clear();
          Console.WriteLine("Division Game");
          Console.WriteLine("Press enter to return back to menu.");
          Console.ReadLine();
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