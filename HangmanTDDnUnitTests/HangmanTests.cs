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
    }
}