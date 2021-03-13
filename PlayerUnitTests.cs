using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


using WheelOfFortuneV2;

namespace WheelOfFortuneV2_test
{

    [TestClass]
    public class PlayerUnitTests
    {

        [TestMethod]
        public void playerNamePropertyIsSet()
        {
            string testName = "Miko";
            Player mikoPlayer = new Player("Miko");

            Assert.AreEqual(typeof(string), mikoPlayer.name.GetType());
            StringAssert.Contains(testName, mikoPlayer.name);
        }

        [TestMethod]
        public void playerNameCanReturn()
        {
            string testName = "Miko";
            Player mikoPlayer = new Player("Miko");

            StringAssert.Contains(testName, mikoPlayer.getName());
        }

        [TestMethod]
        public void guessPhraseReturnsAString()
        {
            Player mikoPlayer = new Player("Miko");

            var consoleInput = new StringReader("phrase");
            Console.SetIn(consoleInput);

            Assert.AreEqual("phrase", mikoPlayer.guessPhrase());
        }

        [TestMethod]
        public void guessCharReturnsAChar()
        {
            Player dudePlayer = new Player("Dude");

            var consoleInput = new StringReader("phrase");
            Console.SetIn(consoleInput);

            Assert.AreEqual("phrase"[0], dudePlayer.guessChar());
        }
    }

}
