namespace MathGame;

internal class GameEngine {
  internal void AdditionGame()
  {
    var random = new Random();
    var score = 0;
    var mode = Menu.GameMode.Addition;

    Console.Clear();
    Console.WriteLine($"{mode} Game");

    for (int i = 0; i < 3; i++) {
      var firstNumber = random.Next(1, 10);
      var secondNumber = random.Next(1, 10);
      Console.WriteLine($"Solve {firstNumber} + {secondNumber}");
      var userInput = Helpers.ValidateNumberFromString(Console.ReadLine());
      if (int.Parse(userInput) == firstNumber + secondNumber) {
        Console.WriteLine("Correct! Press enter to view next question.");
        score++;
      } else {
        Console.WriteLine("Incorrect answer. Press enter to view next question.");
      }
      Console.ReadLine();
    }
    Console.WriteLine($"Your score is: {score}");
    ScoreHistory.AddToHistory(score, mode);
    ExitGameMode();
  }

  internal void SubtractionGame()
  {
    var random = new Random();
    var score = 0;
    var mode = Menu.GameMode.Subtraction;
    
    Console.Clear();
    Console.WriteLine($"{mode} Game");

    for (int i = 0; i < 3; i++) {
      var firstNumber = random.Next(1, 10);
      var secondNumber = random.Next(1, 10);
      Console.WriteLine($"Solve {firstNumber} - {secondNumber}");
      var userInput = Helpers.ValidateNumberFromString(Console.ReadLine());
      if (int.Parse(userInput) == firstNumber - secondNumber) {
        Console.WriteLine("Correct! Press enter to view next question.");
        score++;
      } else {
        Console.WriteLine("Incorrect answer. Press enter to view next question.");
      }
      Console.ReadLine();
    }
    Console.WriteLine($"Your score is: {score}");
    ScoreHistory.AddToHistory(score, mode);
    ExitGameMode();
  }

  internal void MultiplicationGame()
  {
    var random = new Random();
    var score = 0;
    var mode = Menu.GameMode.Multiplication;
    
    Console.Clear();
    Console.WriteLine($"{mode} Game");

    for (int i = 0; i < 3; i++) {
      var firstNumber = random.Next(1, 10);
      var secondNumber = random.Next(1, 10);
      Console.WriteLine($"Solve {firstNumber} * {secondNumber}");
      var userInput = Helpers.ValidateNumberFromString(Console.ReadLine());
      if (int.Parse(userInput) == firstNumber * secondNumber) {
        Console.WriteLine("Correct! Press enter to view next question.");
        score++;
      } else {
        Console.WriteLine("Incorrect answer. Press enter to view next question.");
      }
      Console.ReadLine();
    }
    Console.WriteLine($"Your score is: {score}");
    ScoreHistory.AddToHistory(score, mode);
    ExitGameMode();
  }

  internal void DivisionGame()
  {
    var random = new Random();
    var score = 0;
    var mode = Menu.GameMode.Division;
    
    Console.Clear();
    Console.WriteLine($"{mode} Game");

    for (int i = 0; i < 3; i++) {
      var numbers = Helpers.GetDivisionNumbers();
      var firstNumber = numbers[0];
      var secondNumber = numbers[1];
      
      Console.WriteLine($"Solve {firstNumber} / {secondNumber}");
      var userInput = Helpers.ValidateNumberFromString(Console.ReadLine());
      if (int.Parse(userInput) == firstNumber / secondNumber) {
        Console.WriteLine("Correct! Press enter to view next question.");
        score++;
      } else {
        Console.WriteLine("Incorrect answer. Press enter to view next question.");
      }
      Console.ReadLine();
    }
    Console.WriteLine($"Your score is: {score}");
    ScoreHistory.AddToHistory(score, mode);
    ExitGameMode();
  }

  private void ExitGameMode()
  {
    Console.WriteLine("Press enter to return back to menu.");
    Console.ReadLine();
  }
}