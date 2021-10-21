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
        public void SetGuess(int guess)
        {
            _guess = guess;
        }

        /// <summary>
        /// Returns the provided guess.
        /// </summary>
        public string GetGuess()
        {
            Code _code = new Code();
            string code = _code.GetCode();
            string dashes = "";
            if (_guess == 0)
            {
                foreach(int i in code)
                {
                    dashes += "-";
                }
                return dashes;
            }
            else
            {
                return _guess.ToString();
            }
            
            
        }

    }
}
