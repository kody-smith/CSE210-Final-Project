using System;
using System.Collections.Generic;
namespace _07_speed
{
    // Define the Word class here.
    class Word : Actor
    {
        public string rndword;
        private int _points;
        public Word(string _text)
        {
            rndword = _text;
            UpdateWord();
            Setup();
        }

        public void SetPoints(string words)
        {
            //points = length of word
            // string word = words;
            int pointValue = words.Length;
            _points += pointValue;
        }
        public int GetPoints()
        {
            // Points equal number of letters in word
            return _points;
        }

        public void Setup()
        {
            Random rnd = new Random();
            int x = Constants.MAX_X;
            int y = rnd.Next(0,Constants.MAX_Y);
            int xv = rnd.Next(1,3);
            _position = new Point(x,y);
            _velocity = new Point(-xv,0);            
        }

        public void UpdateWord()
        {
            SetText(rndword);
        }

        public void Move()
        {
            MoveNext();
        }
  
    }
}