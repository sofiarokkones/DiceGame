using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheDiceGame;

namespace DiceGameTest
{
    [TestClass]
    public class TestDiceGame
    {
        private IDiceGame _diceGame;

        [TestInitialize]
        public void Initialize()
        {
            _diceGame = new DiceGamerHigherOrLower_SixSidedDice();
        }

        [TestMethod]
        public void Dice_Roll_Obtain_Correct_Nbr()
        {
            int roll = _diceGame.RollDice();
            Assert.IsTrue(roll < 7 && roll > 0);
        }

        [TestMethod]
        public void Higher_Guess_Is_Correct()
        {
            Assert.IsTrue(_diceGame.CheckGuess("higher", 5, 2));
        }

        [TestMethod]
        public void Lower_Guess_Is_Correct()
        {
            Assert.IsTrue(_diceGame.CheckGuess("lower", 2, 5));
        }

        [TestMethod]
        public void Higher_Guess_Is_InCorrect()
        {
            Assert.IsFalse(_diceGame.CheckGuess("higher", 2, 5));
        }

        [TestMethod]
        public void Lower_Guess_Is_InCorrect()
        {
            Assert.IsFalse(_diceGame.CheckGuess("lower", 5, 2));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundOne()
        {
            Assert.AreEqual(1, _diceGame.PointCounter(0, 1));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundThree()
        {
            Assert.AreEqual(5, _diceGame.PointCounter(2, 3));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundSix()
        {
            Assert.AreEqual(10, _diceGame.PointCounter(7, 6));
        }

        [TestMethod]
        public void PointCounter_Counts_Correct_RoundSeven()
        {
            Assert.AreEqual(11, _diceGame.PointCounter(10, 7));
        }
    }
}
