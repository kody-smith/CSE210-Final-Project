using System;

namespace _06_mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Starting point for the Mastermind project.");
            Director theDirector = new Director();
            theDirector.StartGame();
        }
    }
}
