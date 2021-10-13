namespace _05_jumper
{
    class Director
    {
        public bool _keepPlaying;
        public Word _word;
        public Player _player;
        public Display _display;

        /// <summary>
        /// Initializes the actors of the game.
        /// </summary>
        public Director()
        {
            _keepPlaying = true;
            _word = new Word();
            _player = new Player();
            _display = new Display();
        }

       public void StartGame()
        {
            while (_keepPlaying)
            {
                _display.CreateParachute();
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            _player.Input();
        }

        public void DoUpdates()
        {
            _display.AddLetter();
            _display.RemoveLine();
        }

        public void DoOutputs()
        {
            _display.DisplayWord();
        }
    }
}