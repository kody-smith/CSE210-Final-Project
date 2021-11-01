using System;
using System.Collections.Generic;
namespace _07_speed
{
    // Define the Word class here.
    class Word : Actor
    {
        private string _words;

        private List<string> _printwords = new List<string>();

        public string[] _wordArray = {"ace", "right", "walk", "bro", "up", "down", "stop", "win", "dunk", "it", "off", "jump", "empyrean", "arapaima", "guiana", "burrito", "cheese", "queso", "montana", "idaho", "missouri", "florida", "president", "organization", "topaz", "supercalifragilisticexpialidocious", "pound",
            "water", "jersey", "jabberwocky", "persona", "allegory", "reverence", "temple","subtle","demagogue","transient","arid","desert","pizza","intrepid",
            "extraterrestrial","antidote","beach","agriculture","paradise","armistice","accordion","saxophone","piano","enterprise","sovereignty","amendment",
            "lincoln","mercury","sepulchral","nyctophobia","solomon","revelation"};

        public Word(string text)
        {
            for (int i = 0; i < _wordArray.Length; i++)
            {
                Reset();
            }
            

        }

        public void SetPoints(string words)
        {
            
            _words = words;
        }
        public string GetPoints()
        {
            return _words;
        }

        public void Reset()
        {
            Random rnd = new Random();
            int wordchoice = rnd.Next(0,_wordArray.Length);
            _printwords.Add(_wordArray[wordchoice]);
            Console.WriteLine(_wordArray[wordchoice]);

            foreach(string word in _printwords)
            {
                _text = word;
            }
            // _segments.Add(_wordArray[wordchoice]);
        
            int x = Constants.MAX_X;
            int y = rnd.Next(0,Constants.MAX_Y);
            // int x = 200;
            // int y = 200;
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