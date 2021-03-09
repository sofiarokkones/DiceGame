using System;
namespace TheDiceGame
{
    public interface IDiceGame
    {
        int RollDice();

        bool CheckGuess(string guess, int rolledNumberCurrent, int rolledNumberPrevious);

        int PointCounter(int points, int rounds);

        bool PlayGame(string guess, int rolledDiceNumberNext, int rolledDiceNumber);

    }
}
