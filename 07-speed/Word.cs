using System;
using System.Collections.Generic;
namespace _07_speed
{
    // Define the Word class here.
    class Word : Actor
    {
        private string _words;
        public Word(string text)
        {
            Setup();
        }

        public void SetPoints(string words)
        {
            
            _words = words;
        }
        public string GetPoints()
        {
            return _words;
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
            
            return _words;
        }

        public void Move()
        {
            MoveNext();
        }
  
    }
}