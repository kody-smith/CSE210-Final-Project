using System;
namespace _05_jumper
{
    class Player
    {
        public string _letter;
        public void Input()
        {
            Console.Write("Guess a letter [a-z]:");
            _letter = Console.ReadLine();
        }
    }
}