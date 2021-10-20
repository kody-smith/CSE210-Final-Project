using System;
using System.Collections.Generic;
using System.Text;

namespace _06_mastermind
{
    /// <summary>
    /// Keeps track of all of the pieces in play.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Board
    {
        // TODO: Declare any member variables here.
        List<int> _piles = new List<int>();
        /// <summary>
        /// Initialize the Board
        /// </summary>
        public Board()
        {
            Prepare();
        }

        /// <summary>
        /// A helper method that sets up the board in a new random state.
        /// This could be called by the constructor, or if it is desired
        /// to play again.
        /// 
        /// It should have 2-5 piles with 1-9 stones in each.
        /// Possibly delete
        /// </summary>
        private void Prepare()
        {
            _piles.Clear();
            Random rnd = new Random();
            int pile = rnd.Next(2,6);
            for(int i = 0; i < 5; i++)
            {
                int stones = rnd.Next(1,10);
                _piles.Add(stones);
                Console.WriteLine(stones);
            }
            
            
        }

        /// <summary>
        /// Applies this move by removing the number of stones
        /// from the pile specified in the move.
        /// </summary>
        /// <param name="move">Contains the pile and the number of stones</param>
        public void Apply(Guess guess)
        {
            int stones = move.GetStones();
            int pile = move.GetPile();

            int newAmount = _piles[pile] - stones;

            _piles[pile] = Math.Max(0, newAmount);
        }

        /// <summary>
        /// Indicates if the board is empty (no more stones)
        /// </summary>
        /// <returns>True, if there are no more stones</returns>
        public bool IsEmpty()
        {
            bool areStonesLeft = false;

            foreach (int pile in _piles)
            {
                if (pile > 0)
                {
                    areStonesLeft = true;
                    break;
                }
            }

            return !areStonesLeft;
        }

        /// <summary>
        /// Get's a string representation of the board in the format:
        /// 
        /// --------------------
        /// 0: O O O O O O 
        /// 1: O O O O O O O
        /// 2: O O O O O O O O 
        /// 3: O O O O 
        /// --------------------
        /// </summary>
        /// <returns>The string representation.</returns>
        public override string ToString()
        {
            string text = "\n---------------------\n";
            
            for (int i = 0; i < _piles.Count; i++)
            {
                text += GetTextForPile(i, _piles[i]);
            }
            text += "---------------------\n";

            return text;
        }

        /// <summary>
        /// A helper function that is used by the general ToString method.
        /// This one gets the text for a specific pile in the format:
        /// 
        /// 2: O O O O O O O O 
        /// 
        /// </summary>
        /// <param name="pileNumber">The pile number to display at the front of the line.</param>
        /// <param name="stones">The number of stones in the pile</param>
        /// <returns></returns>
        private string GetTextForPile(int pileNumber, int stones)
        {
            string text = $"{pileNumber}: ";
            
            for (int i = 0; i <= stones; i++)
            {
                text += "O ";
            }
            text += "\n";

            return text;
            
            
        }
    }
}
