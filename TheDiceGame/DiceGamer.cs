using System;
namespace TheDiceGame
{
    public class DiceGamerHigherOrLower : IDiceGame
    {
        private int diceSides;

        public DiceGamerHigherOrLower(int diceSides)
        {
            this.diceSides = diceSides;
        }

        public int RollDice()
        {
            return new Random().Next(1, diceSides);
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

        public bool PlayGame(string guess, int rolledDiceNumberNext, int rolledDiceNumber)
        {
            switch (guess)
            {
                case "higher":
                    {
                        if (CheckGuess(guess, rolledDiceNumberNext, rolledDiceNumber))
                            return true;

                        return false;
                    }
                case "lower":
                    {
                        if (CheckGuess(guess, rolledDiceNumberNext, rolledDiceNumber))
                            return true;

                        return false;
                    }
                default:
                    return false;
            }


        }

    }
}
