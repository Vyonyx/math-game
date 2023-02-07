namespace MathGame;

internal static class Helpers {
  internal static string ValidateNonEmptyString(string str) {
    while (string.IsNullOrEmpty(str)) {
      Console.WriteLine("Please input at least one letter corresponding with the options in the menu.");
      str = Console.ReadLine();
    }
    return str;
  }
}
