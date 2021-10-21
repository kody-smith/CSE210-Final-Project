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
        private Code _code;
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
            
            string code = _code.GetCode();
            string dashes = "";
            if (_guess == 0)
            {
                foreach(char i in code)
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
