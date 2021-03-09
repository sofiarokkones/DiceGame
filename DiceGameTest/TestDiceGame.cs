using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheDiceGame;

namespace DiceGameTest
{
    [TestClass]
    public class TestDiceGame
    {
        private IDiceGame diceGame;

        [TestInitialize]
        public void Initialize()
        {
            diceGame = new DiceGamerHigherOrLower(6);
        }

        [TestMethod]
        public void Dice_Roll_Obtain_Correct_Nbr()
        {
            int roll = diceGame.RollDice();
            Assert.IsTrue(roll < 7 && roll > 0);
        }

        [TestMethod]
        public void Higher_Guess_Is_Correct()
        {
            Assert.IsTrue(diceGame.CheckGuess("higher", 5, 2));
        }

        [TestMethod]
        public void Lower_Guess_Is_Correct()
        {
            Assert.IsTrue(diceGame.CheckGuess("lower", 2, 5));
        }

        [TestMethod]
        public void Higher_Guess_Is_InCorrect()
        {
            Assert.IsFalse(diceGame.CheckGuess("higher", 2, 5));
        }

        [TestMethod]
        public void Lower_Guess_Is_InCorrect()
        {
            Assert.IsFalse(diceGame.CheckGuess("lower", 5, 2));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundOne()
        {
            Assert.AreEqual(1, diceGame.PointCounter(0, 1));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundThree()
        {
            Assert.AreEqual(5, diceGame.PointCounter(2, 3));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundSix()
        {
            Assert.AreEqual(10, diceGame.PointCounter(7, 6));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundSeven()
        {
            Assert.AreEqual(11, diceGame.PointCounter(10, 7));
        }
    }
}
