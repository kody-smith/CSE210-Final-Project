using System;
using System.Collections.Generic;
namespace _07_speed
{
    // Define the Word class here.
    class Word : Actor
    {
        private string _words;

        private List<Actor> _segments = new List<Actor>();

        public string[] _wordArray = {"ace", "right", "walk", "bro", "up", "down", "stop", "win", "dunk", "it", "off", "jump", "empyrean", "arapaima", "guiana", "burrito", "cheese", "queso", "montana", "idaho", "missouri", "florida", "president", "organization", "topaz", "supercalifragilisticexpialidocious", "pound",
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
            
            int x = Constants.MAX_X;
            int y = rnd.Next(0,Constants.MAX_Y);


            _position = new Point(x,y);
            _velocity = new Point(x, y);

            UpdateWord();
        }

        public string UpdateWord()
        {
            return _words;
        }

        public void Move()
        {
            // First move them all forward...
            foreach (Actor actor in _segments)
            {
                actor.MoveNext();
            }

            // Now update the velocity for each one to have the velocity of the segment before
            for (int i = _segments.Count - 1; i >= 0; i--)
            {
                    Actor currentSegment = _segments[i];
                    Actor segmentBefore = _segments[i - 1];

                    Point velocity = segmentBefore.GetVelocity();
                    currentSegment.SetVelocity(velocity);
            }
        }
        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }

    }
}