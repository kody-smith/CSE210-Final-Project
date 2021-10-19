using System;

namespace _06_nim
{
    /// <summary>
    /// Contains the pile and the number of stones for a given move.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Guess
    {
        private int _stones;

        /// <summary>
        /// Initializes the move with the provided number of
        /// stones and pile to remove them from.
        /// </summary>
        /// <param name="stones">The amount of stones to remove</param>
        /// <param name="pile">The pile to remove them from</param>
        public Guess(int stones)
        {
            _stones = stones;
        }

        public int GetStones()
        {
            return _stones;
        }

    }
}
