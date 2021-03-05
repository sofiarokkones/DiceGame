using System;
using System.Collections.Generic;

namespace TheDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IDiceGame diceGamer = new DiceGamerHigherOrLower_SixSidedDice();

            Console.WriteLine("Begin the dice game! Roll the dice by clicking any button.");
            Console.ReadKey();
            var rolledDiceNumber = diceGamer.RollDice();

            Console.WriteLine($"The number of the dice was: {rolledDiceNumber}");
            Console.WriteLine($"Now, guess if next roll will be higher or lower than previous, {rolledDiceNumber}.");
            Console.WriteLine($"If you guess HIGHER: press the UP ARROW. If you guess LOWER: press the DOWN ARROW. ");
            var rolledDiceNumberNext = diceGamer.RollDice();

            int points = 0;
            int rounds = 1;

            while (true)
            {
                var pressedKey = Console.ReadKey().Key;

                if (diceGamer.PlayGame(pressedKey, rolledDiceNumberNext, rolledDiceNumber))
                {
                    points = diceGamer.PointCounter(points, rounds);
                    rounds++;
                    Console.WriteLine($"You were CORRECT, your score is {points} points! " +
                        $"The next number was {rolledDiceNumberNext}!");
                }
                else
                {
                    Console.WriteLine($"You were NOT CORRECT, the next number was {rolledDiceNumberNext}. " +
                        $"You got the final score {points} points. GAME OVER.");
                    return;
                }

                Console.WriteLine($"Guess again, is the next roll higher or lower than the previous one, {rolledDiceNumberNext}?");
                rolledDiceNumber = rolledDiceNumberNext;
                rolledDiceNumberNext = diceGamer.RollDice();
            }

        }
    }
}
