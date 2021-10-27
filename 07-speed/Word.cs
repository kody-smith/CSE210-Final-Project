using System;
using System.Collections.Generic;
namespace _07_speed
{
    // Define the Word class here.
    class Word : Actor
    {
        private string _words;

        public string[] _wordArray = {"empyrean", "arapaima", "guiana", "burrito", "cheese", "queso", "montana", "idaho", "missouri", "florida", "president", "organization", "topaz", "supercalifragilisticexpialidocious", "pound",
            "water", "jersey", "jabberwocky", "persona", "allegory", "reverence", "temple","subtle","demagogue","transient","arid","desert","pizza","intrepid",
            "extraterrestrial","antidote","beach","agriculture","paradise","armistice","accordion","saxophone","piano","enterprise","sovereignty","amendment",
            "lincoln","mercury","sepulchral","nyctophobia","solomon","revelation"};

        public Word()
        {
            Reset();

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
            _words = _wordArray[wordchoice];
            _text = _words.ToString();
            int x = rnd.Next(0,Constants.MAX_X);
            int y = rnd.Next(0,Constants.MAX_Y);
            _position = new Point(x, y);
        }

    }
}