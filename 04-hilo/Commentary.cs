using System;

namespace cse210_tc04
{
    class Commentary
    {
        public string _posCommentary;
        public string _negCommentary;

        ///<summary>
        /// Creates a random positive commentary for enjoyment
        /// I guess you could say this is Commentary in Commentary... within Commentary?
        ///</summary>
        public void PosCommentary()
        {
            Random randGenerator = new Random();
            int randNum = randGenerator.Next(1,9);
            
            if (randNum == 1)
            {
                Console.WriteLine("Good effort on that one bud, I couldn't have done a better job than that");
            }
            else if (randNum == 2)
            {
                Console.WriteLine("Nice guesswork! I wonder if you can get to a thousand here soon?");
            }
            else if (randNum == 3)
            {
                Console.WriteLine("Not bad, not bad. Although, these are rookie numbers though and I bet you can get even higher pretty fast.");
            }
            else if (randNum == 4)
            {
                Console.WriteLine("Ooh, good job on thinking it was that.");
            }
            else if (randNum == 5)
            {
                Console.WriteLine("I might get a bit jealous if you keep this up.");
            }
            else if (randNum == 6)
            {
                Console.WriteLine("Wow, solid guess you made.");
            }
            else if (randNum == 7)
            {
                Console.WriteLine("I would've have suggested the opposite, but I can't argue with your choice now.");
                
            }
            else if (randNum == 8)
            {
                Console.WriteLine("I think that was quite a good choice");
            }
            
        }
        ///<summary>
        /// Creates a random negative commentary for enjoyment
        ///</summary>
        public void NegCommentary()
        {
            Random randGenerator = new Random();
            int randNum = randGenerator.Next(1,9);
            
            if (randNum == 1)
            {
                Console.WriteLine("Not good, but you got the next guess.");
            }
            else if (randNum == 2)
            {
                Console.WriteLine("Alright, we can rectify this with a better guess after this one.");
            }
            else if (randNum == 3)
            {
                Console.WriteLine("Alright, it's not good, but we're still here at least.");
            }
            else if (randNum == 4)
            {
                Console.WriteLine("Hmmm. I thought it was a good guess.");
            }
            else if (randNum == 5)
            {
                Console.WriteLine("I recommend a number.... well you did that, so A+ for effort bud.");
            }
            else if (randNum == 6)
            {
                Console.WriteLine("We might be losing some points but it's merely a flesh wound.");
            }
            else if (randNum == 7)
            {
                Console.WriteLine("I.... I just... don't know what to say, EXCEPT GOOD TRY.");
                
            }
            else if (randNum == 8)
            {
                Console.WriteLine("Dang, that stinks.");
            }
        }
    }
}