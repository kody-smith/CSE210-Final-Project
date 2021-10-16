using System;
namespace _05_jumper
{
    class Director
    {
        public bool _keepPlaying;
        public Word _word;
        public Player _player;
        public Display _display;
        //Added the same member variables here to help with the new function.

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
            _word.ChooseWord();
            _word.DisplayWord();
            Console.WriteLine();
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
            _word.AddLetter(_player._guessChar,_player._letter);
            _display.RemoveLife(_display._wordChoice);
        }

        public void DoOutputs()
        {
            _word.DisplayWord();
        }
    }
}