namespace MathGame;

internal static class Helpers {
  internal static string ValidateNonEmptyString(string str) {
    while (string.IsNullOrEmpty(str)) {
      Console.WriteLine("Please input at least one letter corresponding with the options in the menu.");
      str = Console.ReadLine();
    }
    return str;
  }

  internal static string ValidateNumberFromString(string num) {
    while (string.IsNullOrEmpty(num) || !Int32.TryParse(num, out _)) {
      Console.WriteLine("Invalid entry. Please enter a number to answer the question.");
      num = Console.ReadLine();
    }
    return num;
  }
}
