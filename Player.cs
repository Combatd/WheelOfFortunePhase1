using System;

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
public class Player
{
	// instance variables
	// public string memberName; // name of the player

	public Player()
	{
		// this.name = name;
	}

	public string guessPhrase()
    {
		/*
		 * #guessPhrase() allows the Player to guess the phrase to win the round.
		 * it should grab a string that is read from the Console.ReadLine().
		 * This may be invoked in TurnManager#promptGuess.
		 * It returns a string from the user input.
		 */
    }

	public char guessChar()
    {
		/*
		 * #guessChar allows the Player to guess a character in a phrase.
		 * It should grab a char that is read from the Console.ReadLine().
		 * This may be invoked in TurnManager#promptGuess.
		 * It returns a char from the user input.
		 */
    }
}
