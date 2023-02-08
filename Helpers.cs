namespace MathGame;

internal static class Helpers {
  internal static string ValidateNonEmptyString(string? str)
  {
    while (string.IsNullOrEmpty(str)) {
      Console.WriteLine("Please input at least one letter corresponding with the options in the menu.");
      str = Console.ReadLine();
    }
    return str;
  }

  internal static string ValidateNumberFromString(string? num)
  {
    while (string.IsNullOrEmpty(num) || !Int32.TryParse(num, out _)) {
      Console.WriteLine("Invalid entry. Please enter a number to answer the question.");
      num = Console.ReadLine();
    }
    return num;
  }

  internal static int[] GetDivisionNumbers()
  {
    var random = new Random();
    var numbers = new int[2];
    var upperLimit = 40;

    var firstNumber = random.Next(1, upperLimit);
    var secondNumber = random.Next(1, upperLimit);

    while (firstNumber % secondNumber != 0) {
      firstNumber = random.Next(1, upperLimit);
      secondNumber = random.Next(1, upperLimit);
    }

    numbers[0] = firstNumber;
    numbers[1] = secondNumber;

    return numbers;
  }
}
