using System;
namespace TheDiceGame
{
    public class DiceGamerHigherOrLower_SixSidedDice : IDiceGame
    {

        public int RollDice()
        {
            return new Random().Next(1, 6);
        }

        public bool CheckGuess(string guess, int rolledNumberCurrent, int rolledNumberPrevious)
        {
            switch (guess)
            {
                case "higher":
                    if (rolledNumberCurrent > rolledNumberPrevious)
                        return true;
                    break;
                case "lower":
                    if (rolledNumberCurrent < rolledNumberPrevious)
                        return true;
                    break;
            }
            return false;
        }

        public int PointCounter(int points, int rounds)
        {
            if (rounds % 3 == 0)
            {
                return points + 3;
            }
            return points + 1;
        }

        public bool PlayGame(ConsoleKey pressedKey, int rolledDiceNumberNext, int rolledDiceNumber)
        {
            switch (pressedKey)
            {
                case ConsoleKey.UpArrow:
                    {
                        var guess = "higher";
                        if (CheckGuess(guess, rolledDiceNumberNext, rolledDiceNumber))
                            return true;

                        return false;
                    }
                case ConsoleKey.DownArrow:
                    {
                        var guess = "lower";
                        if (CheckGuess(guess, rolledDiceNumberNext, rolledDiceNumber))
                            return true;

                        return false;
                    }
                default:
                    Console.WriteLine("You clicked another key than the up or down arrow... Game over.");
                    return false;
            }


        }

    }
}
