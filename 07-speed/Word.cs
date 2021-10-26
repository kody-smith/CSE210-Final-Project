using System;
using System.Collections.Generic;
namespace _07_speed
{
    // TODO: Define the Food class here.
    class Word : Actor
    {
        private int _points;
        

        public Word()
        {
            Reset();

        }

        public void SetPoints(int points)
        {
            
            _points = points;
        }
        public int GetPoints()
        {
            return _points;
        }

        public void Reset()
        {
            Random rnd = new Random();
            _points = rnd.Next(1,11);
            _text = _points.ToString();
            int x = rnd.Next(0,Constants.MAX_X);
            int y = rnd.Next(0,Constants.MAX_Y);
            _position = new Point(x, y);
        }

    }
}