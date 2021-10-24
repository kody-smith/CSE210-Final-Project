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
            
            string dash = "----";
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                Player player = new Player(name);
                Guess g = new Guess();
                g.SetGuess(dash);
                player.SetGuess(g);

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
            // Get Player's guess 
        
            string CurrentPlayer = currentPlayer.GetName();
          
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn:");
            int playerguess = _userService.GetNumberInput("What is your guess?: ");

            
            //Set guess for current player
            Guess g = new Guess();
            g.SetGuess(playerguess.ToString());
            // Set the overall guess for the player
            currentPlayer.SetGuess(g);
        }

        private void DoUpdates()
        {
            //Advance to next player

            _roster.AdvanceNextPlayer();
        }

        private void DoOutputs()
        {
            Console.WriteLine("-----------");
            //Goes through each player in the roster, print name, guess, and hint
            foreach (Player p in _roster.GetPlayerList())
            {
                Console.WriteLine($"{p.GetName()}: {p.GetGuess().GetGuess()}, {_code.ProcessHint(p.GetGuess().GetGuess())}");   
                     
            
                if(p.GetGuess().GetGuess() == _code.GetCode())
                {
                    
                    _keepPlaying = false;
                    Console.WriteLine($"{p.GetName()} won!");
                }
            }
            Console.WriteLine("-----------");
         
            
        }

    }
}