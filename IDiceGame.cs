using System;
namespace TheDiceGame
{
    public interface IDiceGame
    {
        public int RollDice();

        public bool CheckGuess(string guess, int rolledNumberCurrent, int rolledNumberPrevious);

        public int PointCounter(int points, int rounds);

        public bool PlayGame(ConsoleKey pressedKey, int rolledDiceNumberNext, int rolledDiceNumber);

    }
}
