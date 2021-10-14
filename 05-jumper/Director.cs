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
            _display.CreateParachute();
            _display.printParachute();
            while (_keepPlaying)
            {
                
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
            _display.AddLetter(_display.dashes,_display.letter);
            _display.RemoveLife(_display._wordChoice);
        }

        public void DoOutputs()
        {
            // _display.DisplayWord();
        }
    }
}