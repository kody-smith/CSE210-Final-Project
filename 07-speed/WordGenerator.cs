using System;
using System.Collections.Generic;

namespace _07_speed
{
    class WordGenerator
    {
        public static string text = "";
        public static string word = "";
        public string[] _wordArray = {"ace", "right", "walk", "bro", "up", "down", "stop", "win", "dunk", "it", "off", "jump", "empyrean", "arapaima", "guiana", "burrito", "cheese", "queso", "montana", "idaho", "missouri", "florida", "president", "organization", "topaz", "supercalifragilisticexpialidocious", "pound",
            "water", "jersey", "jabberwocky", "persona", "allegory", "reverence", "temple","subtle","demagogue","transient","arid","desert","pizza","intrepid",
            "extraterrestrial","antidote","beach","agriculture","paradise","armistice","accordion","saxophone","piano","enterprise","sovereignty","amendment",
            "lincoln","mercury","sepulchral","nyctophobia","solomon","revelation"};

        public string CreateNewWord()
        {
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, _wordArray.Length);
            string text = _wordArray[rndIndex];
            Word w = new Word(text);
            string word = w.ToString();
            return word;
        }

    }
}