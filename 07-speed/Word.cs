using System;
using System.Collections.Generic;
namespace _07_speed
{
    // Define the Word class here.
    class Word : Actor
    {
        public Word(string _text)
        {
            Setup();
        }

        public void SetPoints(string words)
        {
            
            _text = words;
        }
        public string GetPoints()
        {
            // Points equal number of letters in word
            return _text;
        }

        public void Setup()
        {
            Random rnd = new Random();
            int x = Constants.MAX_X;
            int y = rnd.Next(0,Constants.MAX_Y);
            int xv = -1;
            _position = new Point(x,y);
            _velocity = new Point(xv,0);            
        }

        public string UpdateWord()
        {
            
            return _text;
        }

        public void Move()
        {
            MoveNext();
        }
  
    }
}