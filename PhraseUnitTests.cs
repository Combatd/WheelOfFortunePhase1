using Microsoft.VisualStudio.TestTools.UnitTesting;
using WheelOfFortuneV2;

namespace WheelOfFortuneV2_test
{
    [TestClass]
    public class PhraseUnitTests
    {
        [TestMethod]
        public void getPuzzleReady_10()
        {
            Phrase p = new Phrase("Leap Program");            
            p.GetPuzzleReady();

            char[] testArray = "Leap".ToCharArray();

            CollectionAssert.AreNotEqual(testArray, p.InProgressPuzzle);

        }

        [TestMethod]
        public void getPuzzleReady_20()
        {
            Phrase p = new Phrase("Leap Program");
            p.GetPuzzleReady();

            char[] testArray = "Leap Program".ToCharArray();

            CollectionAssert.AreNotEqual(testArray, p.InProgressPuzzle);
        }

        [TestMethod]
        public void CheckGuess_30()
        {
            Phrase p = new Phrase("Leap Program");
            bool contains = p.CheckGuess('l');

            char playersGuessedLetter = 'f';
            bool containsTest = p.PuzzlePhrase.Contains(playersGuessedLetter);

            Assert.AreNotEqual(contains, containsTest);
        }

        [TestMethod]
        public void CheckGuess_40()
        {
            Phrase p = new Phrase("Leap Program");
            bool contains = p.CheckGuess('l');

            char playersGuessedLetter = 'l';
            bool containsTest = p.PuzzlePhrase.Contains(playersGuessedLetter);

            Assert.AreEqual(contains, containsTest);
        }

        [TestMethod]
        public void CheckGuess_50()
        {
            Phrase p = new Phrase("Leap Program");
            bool contains = p.CheckGuess("Leap Program".ToLower());

            string playersGuessedPhrase = "the cat in the hat";
            bool containsTest = p.PuzzlePhrase.Equals(playersGuessedPhrase);

            Assert.AreNotEqual(containsTest, contains);
        }

        [TestMethod]
        public void CheckGuess_60()
        {
            Phrase p = new Phrase("Leap Program");
            bool contains = p.CheckGuess("Leap Program".ToLower());

            string playersGuessedPhrase = "Leap Program".ToLower();
            bool containsTest = p.PuzzlePhrase.Equals(playersGuessedPhrase);

            Assert.AreEqual(containsTest, contains);
        }


        /// <summary>
        /// fail
        /// </summary>
        /// <param name="playersGuessedLetter"></param>
        /// ***how do I test UpdateDashes when it relies on inProgressPuzzle to have been modified by GetPuzzleReady()
        [TestMethod]
        public void UpdateDashes_01()
        {
            //Arrange
            Phrase p = new Phrase("the cat in the hat");
            p.GetPuzzleReady();
            char playerGuessedLetter = 't';
            p.UpdateDashes(playerGuessedLetter);

            Phrase pTest = new Phrase("the cat in the hat");
            pTest.GetPuzzleReady();
            char matchingLetter = 'e';
            for (int i = 0; i < pTest.PuzzlePhrase.Length; i++)
            {
                if (pTest.PuzzlePhrase[i] == matchingLetter)
                    pTest.InProgressPuzzle[i] = matchingLetter;
            }


            //Assert
            CollectionAssert.AreNotEqual(pTest.InProgressPuzzle, p.InProgressPuzzle);
        }
        /// <summary>
        /// pass
        /// </summary>
        /// <param name="playersGuessedLetter"></param>
        [TestMethod]
        public void UpdateDashes_02()
        {
            //Arrange
            Phrase p = new Phrase("the cat in the hat");
            p.GetPuzzleReady();
            char playerGuessedLetter = 't';
            p.UpdateDashes(playerGuessedLetter);

            Phrase pTest = new Phrase("the cat in the hat");
            pTest.GetPuzzleReady();
            char matchingLetter = 't';
            for (int i = 0; i < pTest.PuzzlePhrase.Length; i++)
            {
                if (pTest.PuzzlePhrase[i] == matchingLetter)
                    pTest.InProgressPuzzle[i] = matchingLetter;
            }

            //Assert
            CollectionAssert.AreEqual(pTest.InProgressPuzzle, p.InProgressPuzzle);
        }


        /// <summary>
        ///fail. checking if the inProgressPUzzle is correctly updated from a dash state to all letters state
        /// </summary>
        /// <param name="playersGuessedPhrase"></param>
        [TestMethod]
        public void UpdateDashes_03()
        {
            Phrase p = new Phrase("the cat in the hat");
            p.GetPuzzleReady();
            string playerGuessedPhrase = "the cat in the hat";
            p.UpdateDashes(playerGuessedPhrase);

            Phrase pTest = new Phrase("the cat in the hat");
            pTest.GetPuzzleReady();
            string notMatchingPhrase = "the cat in the box";
            for (int i = 0; i < pTest.PuzzlePhrase.Length; i++)
            {
                    pTest.InProgressPuzzle[i] = notMatchingPhrase[i];
            }
            
            CollectionAssert.AreNotEqual(p.InProgressPuzzle, pTest.InProgressPuzzle);
        }
        /// <summary>
        ///pass 
        /// </summary>
        /// <param name="playersGuessedPhrase"></param>
        [TestMethod]
        public void UpdateDashes_04()
        {
            //creating a char[] inProgressPuzzle that is a mix of _ and letters
            Phrase p = new Phrase("the cat in the hat");
            p.GetPuzzleReady();
            string playerGuessedPhrase = "the cat in the hat";
            p.UpdateDashes(playerGuessedPhrase);

            Phrase pTest = new Phrase("the cat in the hat");
            pTest.GetPuzzleReady();
            string matchingPhrase = "the cat in the hat";
            for (int i = 0; i < pTest.PuzzlePhrase.Length; i++)
            {
                pTest.InProgressPuzzle[i] = matchingPhrase[i];
            }

            CollectionAssert.AreEqual(p.InProgressPuzzle, pTest.InProgressPuzzle);
        }

        
    }
}

