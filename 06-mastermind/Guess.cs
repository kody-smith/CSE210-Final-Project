using System;

namespace _06_mastermind
{
    /// <summary>
    /// Contains the pile and the number of stones for a given move.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Guess
    {
        private int _guess;

        /// <summary>
        /// Initializes the move with the provided guess.
        /// </summary>
        public Guess(int guess)
        {
            _guess = guess;
        }

        /// <summary>
        /// Returns the provided guess.
        /// </summary>
        public int GetGuess()
        {
            return _guess;
        }

    }
}
