using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random, 6);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.ReadKey();