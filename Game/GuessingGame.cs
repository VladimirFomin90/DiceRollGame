using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{

    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Кубик брошен. У Вас {InitialTries} попытки");

            var attemptsLeft = InitialTries;
            while (attemptsLeft > 0)
            {
                var guess = EnterIntReaderUser.ReadInteger("Введите число от 1 до 6");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Число не угадано");
                --attemptsLeft;
            }
            return GameResult.Loss;

        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                ? "Победа!" : "Попробуй еще";

            Console.WriteLine(message);
        }
    }

}
