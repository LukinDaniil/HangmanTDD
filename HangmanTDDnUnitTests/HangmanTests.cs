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
        public void HangManClassGameInitialisationTest()
        {
            Hangman hangman = new Hangman("test");
            Assert.AreEqual("test", hangman.hiddenWord);
        }
        public void HangManClassSettingOfRemainingAttemptsTest()
        {
            Hangman hangman = new Hangman();
            hangman.setRemainingAttempts(5);
            Assert.AreEqual(5, hangman.remainingAttempts);
        }


    }
}