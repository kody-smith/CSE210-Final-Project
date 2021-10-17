using System;
namespace _05_jumper
{
    class Director
    {
        public bool keepPlaying;
        public Word word;
        public Player player;
        public Display display;
        //Added the same member variables here to help with the new function.

        /// <summary>
        /// Initializes the actors of the game.
        /// </summary>
        public Director()
        {
            keepPlaying = true;
            player = new Player();
            display = new Display();
            word = new Word();
            
        }

       public void StartGame()
        {
            display.CreateParachute();
            word.ChooseWord();
            word.DisplayWord();
            Console.WriteLine();
            display.printParachute();
            while (keepPlaying)
            {
                
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {
            player.Input();
        }

        public void DoUpdates()
        {
            display.printParachute();
            word.AddLetter(player.guessChar,player.letter);
            display.changeParachute();
            display.printParachute();
        }

        public void DoOutputs()
        {
            word.DisplayWord();
        }
    }
}