
using System;

/// <summary>
/// Class handles instantiation of the phrase. It has methods for comparing guessed letter and phrase. 
/// </summary>
namespace WheelOfFortuneV2
{
	public class Phrase
	{
		//changing the puzzle phrase type to string from collection of chars
		//public static string puzzlePhrase = "the cat in the hat";
		//public static char[] inProgressPuzzle = new char[puzzlePhrase.Length];

		private string puzzlePhrase;
		private char[] inProgressPuzzle;

		public Phrase(string phrase)
        {
			puzzlePhrase = phrase.ToLower();
			inProgressPuzzle = new char[puzzlePhrase.Length];
        }
        public string PuzzlePhrase {
			get { return puzzlePhrase; }
			set { puzzlePhrase = value; } 
		}

		public char[] InProgressPuzzle
		{
			get { return inProgressPuzzle; }
			set { inProgressPuzzle = value; }
		}

		/// <summary>
		/// Concealing the puzzle phrase letters with "_"
		/// </summary>
		/// <returns> array of size phrase, filled with "_" in place of the letters</returns>
		public void GetPuzzleReady()
		{
			string puzzlePhrase = PuzzlePhrase; 
			int length = puzzlePhrase.Length;

			//char[] inProgressPuzzle = InProgressPuzzle;
			for (int i = 0; i < length; i++)
			{
				if (puzzlePhrase[i] != ' ')
				{
					InProgressPuzzle[i] = '_';
				}
				else
				{
					InProgressPuzzle[i] = ' ';
				}
			}
			
		}



		/// <summary>
		/// This method checks if the players guessed letter is contained in the phrase
		/// </summary>
		/// <param name="playersGuessedLetter">A char</param>
		/// <returns>boolean value </returns>
		public bool CheckGuess(char guessedLetter)
		{
			char playersGuessedLetter = char.ToLower(guessedLetter);
			string puzzlePhrase = PuzzlePhrase;
			if (!puzzlePhrase.Contains(playersGuessedLetter))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		/// <summary>
		/// This method checks if the players guessed phrase is the puzzle phrase
		/// </summary>
		/// <param name="playersGuessedPhrase">A string</param>
		/// <returns>boolean value </returns>
		public bool CheckGuess(string guessedPhrase)
		{
			string playersGuessedPhrase = guessedPhrase.ToLower();
			string puzzlePhrase = PuzzlePhrase;
			if (!puzzlePhrase.Equals(playersGuessedPhrase))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		/// <summary>
		/// This method replaces the "_" in the inProgressPuzzle with the corresponding letter
		/// </summary>
		/// <param name="playersGuessedLetter">A char</param>
		/// <returns> array of char </returns>
		public void UpdateDashes(char guessedLetter)
		{
			char playersGuessedLetter = char.ToLower(guessedLetter);
			string puzzlePhrase = PuzzlePhrase;
			//char[] inProgressPuzzle = InProgressPuzzle;

			int numOccurances = 0;
			for (int i = 0; i < puzzlePhrase.Length; i++)
			{
				if (puzzlePhrase[i] == playersGuessedLetter)
				{
					InProgressPuzzle[i] = playersGuessedLetter;
					numOccurances++;
				}
			}
		}

		/// <summary>
		/// This method replaces the "_" in the inProgressPuzzle with the corresponding phrase
		/// </summary>
		/// <param name="playersGuessedPhrase">A char</param>
		/// <returns> array of char </returns>
		public char[] UpdateDashes(string guessedPhrase)
		{
			string playersGuessedPhrase = guessedPhrase.ToLower();
			string puzzlePhrase = PuzzlePhrase;
			for (int i = 0; i < puzzlePhrase.Length; i++)
			{
				{
					InProgressPuzzle[i] = puzzlePhrase[i];
				}
			}
			return InProgressPuzzle;
		}
	}
}
