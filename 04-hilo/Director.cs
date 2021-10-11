using System;

namespace cse210_tc04
{
    /// <summary>
    /// Like a director in a play, this class is responsible for the game, the script,
    /// the actors, and all of their interactions.
    /// 
    /// For this program, it has responsibility for the score, coordinating with the
    /// player to choose, and the sequence of play.
    /// </summary>
    class Director
    {
        bool _keepPlaying = true;
        int _score;
        int _current_card_number = 0;
        int rounds;
        Dealer _dealer = new Dealer();
        ///<summary>
        ///  StartGame() will start the game and hold most of the direction of function-use
        ///</summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                CurrentNumber();
                GuessNumber();
                DisplayScore();
                UserInput();
                
            }
        }
        

        /// <summary>
        ///  CurrentNumber() checks the current number of the card you're using and tells you through the console what it is
        /// </summary>
        void CurrentNumber ()
        {
            string CurrentNumber = _dealer.DisplayCard();
            Console.WriteLine($"The card is: {CurrentNumber}");
        }
        ///<summary>
        ///  GuessNumber() asks for the input of your guess
        ///</summary>
        void GuessNumber()
        {
            Console.Write("Higher or lower? ");
            _dealer._guess = Console.ReadLine();
            
        }
        ///<summary>
        ///  UserInput() will keep asking you if you'll want to continue the game or not
        ///</summary>
        void UserInput()
        {
            _dealer.DisplayCard();

           if (!_dealer.IsFirstTurn() && _score > 0)
            {
                Console.WriteLine("Keep playing? [y/n] ");
                string choice = Console.ReadLine();
                _keepPlaying = (choice == "y");
            }
            
        }

        
        ///<summary>
        /// UpdateScore() updates the score each time the user inputs a guess.
        ///</summary>
        void UpdateScore()
        {
            
            _dealer.CheckGuess(_dealer._guess);

            _score = _dealer._starting_score;
        }
        ///<summary>
        /// DisplayScore() Updates the score and displays it to the player.
        ///</summary>
        void DisplayScore()
        {
            UpdateScore();
            DisplayOutput();
        }
        ///<summary>
        ///  DisplayOutput() displays the output of the functions.
        ///</summary>
        void DisplayOutput()
        {
            if(_score > 0) 
            {                 
                        
            Console.WriteLine();
            Console.WriteLine($"Next card is: {_dealer._next_card_number}");
            Console.WriteLine($"Your score is: {_score}");
            }
            else if (_score <= 0)
            {
                Console.WriteLine("Your score is 0.");
                Gameover();
            }
        }
        ///<summary>
        ///  Gameover() prints the end game message.
        ///</summary>
        void Gameover()
        {
            Console.WriteLine("Gameover. Better luck next time.");
        }

       
    } // end of class: Director
}
