namespace MathGame;

internal class GameEngine {
  internal void AdditionGame()
  {
    var random = new Random();
    var score = 0;

    Console.Clear();
    Console.WriteLine("Addition Game");

    for (int i = 0; i < 3; i++) {
      var firstNumber = random.Next(1, 10);
      var secondNumber = random.Next(1, 10);
      Console.WriteLine($"Solve {firstNumber} + {secondNumber}");
      var userInput = Console.ReadLine();
      if (int.Parse(userInput) == firstNumber + secondNumber) {
        Console.WriteLine("Correct! Press enter to view next question.");
        score++;
      } else {
        Console.WriteLine("Incorrect answer. Press enter to view next question.");
      }
      Console.ReadLine();
    }
    Console.WriteLine($"Your score is: {score}");
    ScoreHistory.AddToHistory(score, "Addition");
    ExitGameMode();
  }

  internal void SubtractionGame()
  {
    var random = new Random();
    var score = 0;
    
    Console.Clear();
    Console.WriteLine("Subtraction Game");

    for (int i = 0; i < 3; i++) {
      var firstNumber = random.Next(1, 10);
      var secondNumber = random.Next(1, 10);
      Console.WriteLine($"Solve {firstNumber} - {secondNumber}");
      var userInput = Console.ReadLine();
      if (int.Parse(userInput) == firstNumber - secondNumber) {
        Console.WriteLine("Correct! Press enter to view next question.");
        score++;
      } else {
        Console.WriteLine("Incorrect answer. Press enter to view next question.");
      }
      Console.ReadLine();
    }
    Console.WriteLine($"Your score is: {score}");
    ScoreHistory.AddToHistory(score, "Addition");
    ExitGameMode();

  }

  internal void MultiplicationGame()
  {
    Console.Clear();
    Console.WriteLine("Multiplication Game");
    ExitGameMode();

  }

  internal void DivisionGame()
  {
    Console.Clear();
    Console.WriteLine("Division Game");
    ExitGameMode();
  }

  private void ExitGameMode()
  {
    Console.WriteLine("Press enter to return back to menu.");
    Console.ReadLine();
  }
}