using GameHangman;
using NUnit.Framework;

namespace HangmanTDDnUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HangManClassCreationTest()
        {
            Hangman hangman = new Hangman();
            Assert.NotNull(hangman);
        }
        [Test]
        public void HangManClassGameInitialisationTest()
        {
            Hangman hangman = new Hangman("test");
            Assert.AreEqual("test", hangman.hiddenWord);
        }
        [Test]
        public void HangManClassSettingOfRemainingAttemptsTest()
        {
            Hangman hangman = new Hangman();
            hangman.setRemainingAttempts(5);
            Assert.AreEqual(5, hangman.remainingAttempts);
        }
        [Test]
        public void HangManClassCheckCurrentGameStateEqualHiddenWordTest()
        {
            Hangman hangman = new Hangman("test");
            Assert.AreEqual("____", hangman.checkCurrentGameState());
        }
        [Test]
        public void HangManClassCheckCurrentGameStateEqualHiddenWordTest2()
        {
            Hangman hangman = new Hangman("test2");
            Assert.AreEqual("_____", hangman.checkCurrentGameState());
        }
        [Test]
        public void HangManClassGuessWordTest()
        {
            Hangman hangman = new Hangman("test");
            hangman.guess('t');
            Assert.AreEqual("t__t", hangman.checkCurrentGameState());
        }
        [Test]
        public void HangManClassGuessWordTest2()
        {
            Hangman hangman = new Hangman("test");
            hangman.guess('e');
            Assert.AreEqual("_e__", hangman.checkCurrentGameState());
        }
        [Test]
        public void HangManClassGuessWordFailTest()
        {
            Hangman hangman = new Hangman("test");
            hangman.setRemainingAttempts(5);
            hangman.guess('a');
            Assert.AreEqual("____", hangman.checkCurrentGameState());
            Assert.AreEqual(4, hangman.remainingAttempts);
        }
        [Test]
        public void HangManClassGuessWordFailTest2()
        {
            Hangman hangman = new Hangman("test");
            hangman.setRemainingAttempts(4);
            hangman.guess('a');
            Assert.AreEqual("____", hangman.checkCurrentGameState());
            Assert.AreEqual(3, hangman.remainingAttempts);
        }
        [Test]
        public void HangManClassWinConditionTest()
        {
            Hangman hangman = new Hangman("test");
            hangman.guess('t');
            hangman.guess('e');
            hangman.guess('s');
            hangman.guess('t');
            Assert.IsTrue(hangman.gameWon());
        }
        [Test]
        public void HangManClassWinConditionFailTest()
        {
            Hangman hangman = new Hangman("test");
            hangman.guess('t');
            hangman.guess('e');
            Assert.IsFalse(hangman.gameWon());
        }
    }
}