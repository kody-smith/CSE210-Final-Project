using System;

namespace _06_mastermind
{
    class Director
    {
        private UserService _userService = new UserService();
        private Roster _roster = new Roster();
        private Code _code = new Code();
        private Guess _guess = new Guess();
        private bool _keepPlaying = true;

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
         /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                Player player = new Player(name);
                _roster.AddPlayer(player);
            }
            _code.GenerateCode();
        }


        ///<summary>
        /// Get all needed input from player.
        ///</summary>
        private void GetInputs()
        {
            Player currentPlayer = _roster.GetCurrentPlayer();
            // Display Players and the initial inputs from code (e.g PLAYERNAME: ----, ****)
            // string board = _board.ToString();
            // _userService.DisplayText(board);
        
            string CurrentPlayer = currentPlayer.GetName();
            string hint = _code.GenerateHint();
            string guess = _guess.GetGuess().ToString();
            
            Console.WriteLine($"{CurrentPlayer}: {guess}, {hint}");
            // string hidden = _code.GenerateHint();
            
            // Get next player's guess
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn:");
            int playerguess = _userService.GetNumberInput("What is your guess?: ");

            // set values here for the guess

            // Set the overall guess for the player
        }

        private void DoUpdates()
        {
            _roster.AdvanceNextPlayer();
        }

        private void DoOutputs()
        {

        }
    }
}