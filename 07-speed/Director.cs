using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();

        Word _word = new Word(default);
        WordGenerator _wordGenerator = new WordGenerator();
        ScoreBoard _scoreBoard = new ScoreBoard();
        private List<Word> _words = new List<Word>();

        //Uncomment when buffer is ready
        Buffer _buffer = new Buffer();

        /// <summary>
        ///This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

                if (_inputService.IsWindowClosing() || _inputService.IsEscapePressed())
                {
                    _keepPlaying = false;
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            //Grab single word from Array and set it to a variable. Needs to be set to a list then we use
            // each of the members of that list to print out each actor.
            for(int i = 0; i < 5; i++)
            {
                Word word = _wordGenerator.CreateNewWord();
                _words.Add(word);
            }
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Speed Game", Constants.FRAME_RATE);
        }
        /// <summary>
        /// Get any text input needed from the user for buffer.
        /// </summary>
        private void GetInputs()
        {
          
        }

        /// <summary>
        /// Update any of the actors.
        /// get words and check buffer words and generated words
        /// if the words reach to the left side of screen, player lose score
        /// based on the matching, get score
        /// </summary>
        private void DoUpdates()
        {   
            GenerateNewWords();
            //Call move from Word.cs to change x position
            foreach(Word word in _words)
            {
                word.Move();
            }
            
        }

        /// <summary>
        /// "When user push ENTER_KEY",
        /// Display the updated state of the game to the user.
        /// delete matching word, and add score on thescore board.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);

            foreach(Word word in _words)
            {
                _outputService.DrawActor(word);
            }
                  
                  
            //Uncomment when buffer is ready
            _outputService.DrawActor(_buffer);
            _outputService.EndDrawing();
        }

        private void GenerateNewWords()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1,50);
            if(chance < Constants.GENERATE_WORD_RATE)
            {
                Word w = _wordGenerator.CreateNewWord();
                _words.Add(w);
            }
        }
    }
}
