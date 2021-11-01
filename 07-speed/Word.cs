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
            string word = text;
        }

        public void SetPoints(string words)
        {
            
            _words = words;
        }
        public string GetPoints()
        {
            // Points equal number of letters in word
            return _words;
        }

        public void Setup()
        {
            //Give word position and velocity 
            
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