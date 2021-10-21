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
        private static int guess;
        private static string name = "";
        private Player _player = new Player(name);
        private UserService _userService = new UserService();
        private Guess _guess = new Guess();
        private Code _code = new Code();

        
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
        /// Get's a string representation of the board in the format
        /// </summary>
        /// <returns>The string representation.</returns>
        // public override string ToString()
        // {
        //     _userService.DisplayText($"{_player.GetName()}'s turn:");
        //     int playerguess = _userService.GetNumberInput("What is your guess?: ");
            
        //     Console.WriteLine($"{_guess.GetGuess(playerguess)}");
        //     string hidden = _code.GenerateHint();

        //     return hidden;
        // }
    }
}
