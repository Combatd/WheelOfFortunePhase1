using System;

namespace WheelOfFortuneV2
{


	/// <summary>
	/// Summary description for Player
	/// 
	/// This is the Player class.
	/// It holds the Player's name.
	/// 
	/// name: String
	/// guessPhrase(): String
	/// guessChar(): Char
	/// 
	/// #guessPhrase:
	/// Allows the player to guess a phrase. Returns a string.
	/// 
	/// #guessChar:
	/// Allows the player to guess a one letter char in a phrase. Returns a char.
	/// </summary>
	/// 

	public class Player
	{
		// instance variables
		public string name; // name of the player

		public Player(string nameInput)
		{
			this.name = nameInput;
		}

		/// <summary>
		/// #getName
		/// Access name property of instance
		/// </summary>
		/// 
		/// <returns></returns>
		/// 
		public string getName()
		{
			return this.name;
		}

		/// <summary>
		///  * #guessPhrase() allows the Player to guess the phrase to win the round.
		///	 * it should value of a string that is read from the Console.ReadLine().
		///	 * This may be invoked in TurnManager#promptGuess.
		///	 * It returns a string from the user input.
		/// </summary>
		/// <returns></returns>
		public string guessPhrase()
		{
			string guessedPhrase = Console.ReadLine();
			return guessedPhrase;
		}

		/// <summary>
		/// * #guessChar allows the Player to guess a character in a phrase.
		/// * It should grab a char that is read from the Console.ReadLine().
		/// * This may be invoked in TurnManager#promptGuess.
		/// * It returns a char from the user input.
		/// </summary>
		/// <returns></returns>
		public char guessChar()
		{
			char guessedChar = (char)Console.ReadLine()[0];
			return guessedChar;
		}
	}

}
