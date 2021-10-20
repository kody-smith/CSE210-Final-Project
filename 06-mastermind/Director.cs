using System;

namespace _06_mastermind
{
    class Director
    {
        private UserService _userService = new UserService();
        private Roster _roster = new Roster();
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
        }

        private void GetInputs()
        {

        }

        private void DoUpdates()
        {

        }

        private void DoOutputs()
        {

        }
    }
}