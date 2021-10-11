using System;
using System.Collections.Generic;

namespace cse210_tc04
{   

    /// <summary>
    /// The dealer is responsible for managing the deals which include: 
    /// Showing the card
    /// managing point assignment
    /// </summary>
    class Dealer
    {
        ///<summary>
        /// Member variables go here:
        ///</summary>
        const int NUM_CARDS = 13;
        public int _numDeals;
        public string _guess;
        public int _current_card_number;
        public bool _increase_score;
        public int _score;
        public int _next_card_number;
        public int _starting_score = 300;
        int _rounds = 0;
        Commentary _commentary = new Commentary();


        ///<summary>
        /// Checks to see if it is the first turn
        ///</summary>
        public bool IsFirstTurn()
        {
            return _numDeals == 0;
        }

        ///<summary>
        /// The ResetDeal method handles the clearing of the deal of cards and
        /// generates the next card in the deal.
        ///</summary>
        public void ResetDeal()
        {
            _numDeals++;
            Random randomGenerator = new Random();
            
            int card = randomGenerator.Next(1,14);
            _current_card_number = card;

            int next_card = randomGenerator.Next(1,14);
            _next_card_number = next_card;
        }

        ///<summary>
        /// if guess is correct, next card number gets set as current card number.
        ///</summary>
        public void CheckGuess(string _guess)
        {
            int _numguess;
            if (_guess == "l")
            {
                _numguess = _next_card_number;
                if (_numguess <= _current_card_number)
                {
                    _increase_score = true;
                    CheckScore(_score);
                }
                else if (_numguess > _current_card_number)
                {
                    _increase_score = false;
                    CheckScore(_score);
                }
            }
            if (_guess == "h")
            {
                _numguess = _next_card_number;
                if (_numguess >= _current_card_number)
                {
                    _increase_score = true;
                    CheckScore(_score);
                }
                else if (_numguess < _current_card_number)
                {
                    _increase_score = false;
                    CheckScore(_score);
                }
            }
            
        }
    
        ///<summary>
        /// This will check the current score and appropriately add or subtract the score from the correct or incorrect result.
        ///</summary>
        public int CheckScore(int _score)
        {
            
            if (_increase_score == true)
            {
                _starting_score += 100;
                _commentary.PosCommentary();
            }
            else if (_increase_score == false)
            {
                _starting_score = _starting_score - 75;
                _commentary.NegCommentary();
            }
            _score = _starting_score;
            return _score;
        }

        ///<summary>
        /// This function make the score by usingCheckScore function 
        ///</summary>
        public int PointsPerCard()
        {
            int score = 0;
            int guessNum = int.Parse(_guess);
            score += CheckScore(guessNum);

            return score;
        }

        ///<summary>
        /// This function generates next card
        ///</summary>
        public string DisplayCard()
        {     
            ResetDeal();
            
            string CurrentCard =_current_card_number.ToString();
            return CurrentCard;
        }
    }
}