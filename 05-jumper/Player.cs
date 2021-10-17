using System;
namespace _05_jumper
{
    class Player
    {
        public string letter;
        public char guessChar;
        public void Input()
        {
            Console.Write("Guess a letter [a-z]:");
            letter = Console.ReadLine();
            guessChar = letter.ToCharArray()[0];
        }
    }
}