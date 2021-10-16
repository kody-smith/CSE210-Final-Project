using System;
namespace _05_jumper
{
    class Player
    {
        public string _letter;
        public char guesses;
        public void Input()
        {
            Console.Write("Guess a letter [a-z]:");
            _letter = Console.ReadLine();
            guesses = _letter.ToCharArray()[0];
        }
    }
}